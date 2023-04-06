using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUT22_ÖvningGenerics
{
    internal class StudentEnumrator : IEnumerator<Student>
    {

        private StudentCollection _student;
        private int _currIndex;
        private Student _currStudent;


        public StudentEnumrator(StudentCollection student)
        {
            this._student = student;
            _currIndex = -1;
            _currStudent = default(Student);
        }
        public Student Current { get { return _currStudent; } }

        object IEnumerator.Current { get { return Current; } }



        public void Dispose()
        {
           
        }

        public bool MoveNext()
        {
            if (++_currIndex >= _student.Count)
            {
                return false;
            }
            else
            {
                _currStudent = _student[_currIndex];
            }
            return true;
        }

        public void Reset()
        {
            _currIndex = -1;
        }
    }
}
