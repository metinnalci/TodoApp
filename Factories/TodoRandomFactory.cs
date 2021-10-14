using CSD.TodoApplicationRestApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSD.TodoApplicationRestApp.Factory
{
    public class TodoRandomFactory
    {
        private List<TodoInfo> m_todos;
        private Random m_random = new();

        private void loadTodos()
        {
            m_todos = new List<TodoInfo>
            {
                new TodoInfo{Title = "Eczane", Text = "Vitamin, Aspirin"},
                new TodoInfo{Title = "Market", Text = "Gofret, Biberon"},
                new TodoInfo{Title = "Okul", Text = "Intro ro prog, Software Eng."},
                new TodoInfo{Title = "SüperMarket", Text = "Çay"}

            };
        }

        public TodoRandomFactory()
        {
            loadTodos();
        }

        public IEnumerable<TodoInfo> All => m_todos;

        public TodoInfo RandomTodo => m_todos[m_random.Next(m_todos.Count)];


        public IEnumerable<TodoInfo> GetByCount(int number)
        {
            var list = new List<TodoInfo>();

            if (number <= m_todos.Count)
            {
                for (int i = 0; i < number; i++)
                {
                    list.Add(m_todos[i]);
                }
            }
            

            return list;
        }

        public IEnumerable<TodoInfo> FindTodosByTitleContains(string title)
        {
            var list = new List<TodoInfo>();

            foreach (var item in m_todos)
            {
                if (item.Title.Contains(title))
                {
                    list.Add(item);
                }
            }

            return list;

        }


    }
}
