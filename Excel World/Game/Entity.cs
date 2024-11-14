using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excel_World.Game
{
    public class Entity
    {
        private List<Component> m_components = new();

        public List<Component> Components => m_components;

        public List<IUpdateable> m_updateableComponents = new();

        public List<IDrawable> m_drawableComponents = new();

        public Project Project { get; set; }

        public string Name { get; set; }

        public void AddComponent(Component component)
        {
            component.Project = Project;
            component.Entity = this;
            m_components.Add(component);

            m_updateableComponents.Clear();
            foreach (Component subsystem1 in m_components)
            {
                if (subsystem1 is IUpdateable updateable) m_updateableComponents.Add(updateable);
            }
            m_updateableComponents.Sort(UpdateableComparer.Instance);

            m_drawableComponents.Clear();
            foreach (Component subsystem1 in m_components)
            {
                if (subsystem1 is IDrawable drawable) m_drawableComponents.Add(drawable);
            }
            m_drawableComponents.Sort(DrawableComparer.Instance);
        }

        public void RemoveComponent(Component component)
        {
            component.Project = null;
            component.Entity = null;
            m_components.Remove(component);

            m_updateableComponents.Clear();
            foreach (Component subsystem1 in m_components)
            {
                if (subsystem1 is IUpdateable updateable) m_updateableComponents.Add(updateable);
            }
            m_updateableComponents.Sort(UpdateableComparer.Instance);

            m_drawableComponents.Clear();
            foreach (Component subsystem1 in m_components)
            {
                if (subsystem1 is IDrawable drawable) m_drawableComponents.Add(drawable);
            }
            m_drawableComponents.Sort(DrawableComparer.Instance);
        }

        public T GetComponent<T>(bool throwOnNull = false) where T : Component
        {
            Component component = m_components.FirstOrDefault(x => x is T);
            if (component == null && throwOnNull)
            {
                throw new KeyNotFoundException($"Component of type {typeof(T).Name} not found.");
            }
            return component as T;
        }

        public void UpdateComponents(float dt)
        {
            foreach (IUpdateable updateable in m_updateableComponents) 
            {
                updateable.Update(dt);
            }
        }

        public void FixedUpdateComponent(float dt)
        {
            foreach (IUpdateable updateable in m_updateableComponents)
            {
                updateable.FixedUpdate(dt);
            }
        }

        public void DrawComponents(Dictionary<Point2, string> requires)
        {
            foreach (IDrawable drawable in m_drawableComponents)
            {
                drawable.Draw(requires);
            }
        }
    }
}
