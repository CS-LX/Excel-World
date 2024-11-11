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

        public Project Project { get; set; }

        public void AddComponent(Component component)
        {
            component.Project = Project;
            m_components.Add(component);
        }

        public void RemoveComponent(Component component)
        {
            component.Project = null;
            m_components.Remove(component);
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
            foreach (Component component in m_components) 
            {
                if (component is IUpdateable updateable)
                {
                    updateable.Update(dt);
                }
            }
        }

        public void FixedUpdateComponent(float dt)
        {
            foreach (Component component in m_components)
            {
                if (component is IUpdateable updateable)
                {
                    updateable.FixedUpdate(dt);
                }
            }
        }
    }
}
