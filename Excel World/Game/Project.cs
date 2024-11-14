using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excel_World.Game
{
    public class Project
    {
        private List<Subsystem> m_subsystems = new();

        private List<IUpdateable> m_updateableSubsystems = new();

        private List<IDrawable> m_drawableSubsystems = new();

        private List<Entity> m_entities = new();

        public void AddEntity(Entity entity)
        {
            entity.Project = this;
            m_entities.Add(entity);
        }

        public void RemoveEntity(Entity entity)
        {
            entity.Project = null;
            m_entities.Remove(entity);
        }

        public void AddSubsystem(Subsystem subsystem) 
        {
            subsystem.Project = this;
            m_subsystems.Add(subsystem);

            m_updateableSubsystems.Clear();
            foreach (Subsystem subsystem1 in m_subsystems)
            {
                if (subsystem1 is IUpdateable updateable) m_updateableSubsystems.Add(updateable);
            }
            m_updateableSubsystems.Sort(UpdateableComparer.Instance);

            m_drawableSubsystems.Clear();
            foreach (Subsystem subsystem1 in m_subsystems)
            {
                if (subsystem1 is IDrawable drawable) m_drawableSubsystems.Add(drawable);
            }
            m_drawableSubsystems.Sort(DrawableComparer.Instance);
        }

        public void RemoveSubsystem(Subsystem subsystem)
        {
            subsystem.Project = null;
            m_subsystems.Remove(subsystem);

            m_updateableSubsystems.Clear();
            foreach (Subsystem subsystem1 in m_subsystems)
            {
                if (subsystem1 is IUpdateable updateable) m_updateableSubsystems.Add(updateable);
            }
            m_updateableSubsystems.Sort(UpdateableComparer.Instance);

            m_drawableSubsystems.Clear();
            foreach (Subsystem subsystem1 in m_subsystems)
            {
                if (subsystem1 is IDrawable drawable) m_drawableSubsystems.Add(drawable);
            }
            m_drawableSubsystems.Sort(DrawableComparer.Instance);
        }

        public void Update(float dt)
        {
            UpdateSubsystems(dt);
            UpdateEntities(dt);
        }

        public void FixedUpdate(float dt)
        {
            FixedUpdateSubsystems(dt);
            FixedUpdateEntities(dt);
        }

        public void UpdateEntities(float dt)
        {
            foreach (Entity entity in m_entities) 
            {
                entity.UpdateComponents(dt);
            }
        }

        public void FixedUpdateEntities(float dt)
        {
            foreach (Entity entity in m_entities)
            {
                entity.FixedUpdateComponent(dt);
            }
        }

        public void DrawEntities(Dictionary<Point2, string> requires)
        {
            foreach (Entity entity in m_entities)
            {
                entity.DrawComponents(requires);
            }
        }

        public void UpdateSubsystems(float dt)
        {
            foreach (IUpdateable updateable in m_updateableSubsystems)
            {
                updateable.Update(dt);
            }
        }

        public void FixedUpdateSubsystems(float dt)
        {
            foreach (IUpdateable updateable in m_updateableSubsystems)
            {
                updateable.FixedUpdate(dt);
            }
        }

        public void DrawSubsystems(Dictionary<Point2, string> requires)
        {
            foreach (IDrawable drawable in m_drawableSubsystems)
            {
                drawable.Draw(requires);
            }
        }

        public T FindSubsystem<T>(bool throwOnNull = false) where T : Subsystem
        {
            Subsystem subsystem = m_subsystems.FirstOrDefault(x => x is T);
            if (subsystem == null && throwOnNull)
            {
                throw new KeyNotFoundException($"Subsystem of type {typeof(T).Name} not found.");
            }
            return subsystem as T;
        }

        public Entity FindEntity(string name) => m_entities.Find(x => x.Name == name);

        public void Load()
        {
            m_subsystems.ForEach(x => x.Load());
        }

        public void Save()
        {
            m_subsystems.ForEach(x => x.Save());
        }
    }


    public class UpdateableComparer : IComparer<IUpdateable>
    {
        public static UpdateableComparer Instance = new();

        public int Compare(IUpdateable u1, IUpdateable u2)
        {
            int num = u1.UpdateOrder - u2.UpdateOrder;
            if (num != 0)
            {
                return num;
            }
            return u1.GetHashCode() - u2.GetHashCode();
        }
    }

    public class DrawableComparer : IComparer<IDrawable>
    {
        public static DrawableComparer Instance = new();

        public int Compare(IDrawable u1, IDrawable u2)
        {
            int num = u1.DrawOrder - u2.DrawOrder;
            if (num != 0)
            {
                return num;
            }
            return u1.GetHashCode() - u2.GetHashCode();
        }
    }
}
