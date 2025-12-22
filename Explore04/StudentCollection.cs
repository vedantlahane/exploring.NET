using System;
class StudentCollection
{
    private string[] students = new string[3];
    public string this[int index]
    {
        get
        {
            if(index < 0 || index >= students.Length)
            {
                throw new IndexOutOfRangeException("Index is out of range.");
            }
            return students[index];
        }
        set
        {
            if(index >= 0 && index < students.Length)
            {
                students[index] = value;
            }
            else
            {
                throw new IndexOutOfRangeException("Index is out of range.");
            }
        }
    }
}