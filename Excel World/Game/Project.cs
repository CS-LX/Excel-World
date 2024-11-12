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
            m_updateableSubsystems.Sort(SubsystemComparer.Instance);
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
            m_updateableSubsystems.Sort(SubsystemComparer.Instance);
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

        public void UpdateSubsystems(float dt)
        {
            foreach(Subsystem subsystem in m_subsystems)
            {
                if (subsystem is IUpdateable updateable)
                {
                    updateable.Update(dt);
                }
            }
        }

        public void FixedUpdateSubsystems(float dt)
        {
            foreach (Subsystem subsystem in m_subsystems)
            {
                if (subsystem is IUpdateable updateable)
                {
                    updateable.FixedUpdate(dt);
                }
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
    }


    public class SubsystemComparer : IComparer<IUpdateable>
    {
        public static SubsystemComparer Instance = new();

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
}
