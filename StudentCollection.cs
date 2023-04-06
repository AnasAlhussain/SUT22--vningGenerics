using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUT22_ÖvningGenerics
{
    internal class StudentCollection : ICollection<Student>
    {


        private List<Student> innerCol;
        

        public StudentCollection() { innerCol = new List<Student>(); }

        public Student this[int index]
        {
            get { return (Student)innerCol[index]; }
            set { innerCol[index] = value; }
        }
        public int Count
        {
            get { return innerCol.Count; }
        }

        public bool IsReadOnly { get { return false; } }

        public void Add(Student item)
        {
            if (!Contains(item))
            {
                innerCol.Add(item);
            }
            else
            {
                Console.WriteLine(" A Student with ID : {0} , Grade : {1} Total :  {2} Prop Was allready added",
                    item.ID.ToString(),item.Grade.ToString(), item.Total.ToString());
            }
        }

        public void Clear()
        {
            innerCol.Clear();
        }

        public bool Contains(Student item)
        {
            bool found = false;
            foreach (Student s in innerCol) 
            {
                if (s.Equals(item))
                {
                    found = true;
                }
            
            }
            return found;
        }

            public bool Contains(Student item ,EqualityComparer<Student> comp)
                {
            bool found = false;
            foreach(Student s in innerCol)
            {
                if(comp.Equals(s , item))
                {
                    found = true;
                }
                {

                }
            }
            return found;

                }
               
            public void CopyTo(Student[] array, int arrayIndex)
        {
            if(array == null)
            {
                throw new ArgumentNullException("The Array cannot be null");
            }
            if(arrayIndex < 0)
            {
                throw new ArgumentOutOfRangeException("The statring array index can not be negative");
            }
            if(Count > array.Length - arrayIndex + 1)
            {
                throw new ArgumentException("The destaniation array has fewer elements than the collaction");
            }

            for(int i = 0; i < innerCol.Count; i++)
            {
                array[i + arrayIndex] = innerCol[i];
            }
        }

        public IEnumerator<Student> GetEnumerator()
        {
            return new StudentEnumrator(this);
        }

        public bool Remove(Student item)
        {
            bool result = false;
            for(int i = 0; i < innerCol.Count; i++)
            {
                Student student = innerCol[i];
                if(new StudentSameProp().Equals(student, item))
                {
                    innerCol.RemoveAt(i);
                    result = true;
                    break;
                }
            }
            return result;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new StudentEnumrator(this);
        }
    }
}
