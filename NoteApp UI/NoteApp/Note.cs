using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp
{
    public class Note
    {
        ///<summary>
        ///Название
        ///</summary>
        private string _title;
        ///<summary>
        ///Категории заметок
        ///</summary>
        private NoteCategory _ NoteCategory;
        ///<summary>
        ///Текст заметки
        ///</summary>
        private string _noteText;
        ///<summary>
        ///Время создания
        ///</summary>
        
        private DateTime _timeCreated { get; }

        ///<summary>
        ///Время последнего изменения
        ///</summary>
        
        private DateTime _timeModificated { get; }
        ///<summary>
        ///заголовок не должен быть длинее 50 символов
        ///</summary>
        
        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                if (value.Length > 50)
                {
                    throw new ArgumentException("Заголовок должен содержать не более 50 символов, а содержал" + value.Length);
                }
                _title = value;
            }
        }

        public NoteCategory Category
        {
            get { return _NoteCategory; }
            set { _NoteCategory = value; }
        }

        public string NoteText
        {
            get
            {
                return _noteText;
            }
            set
            {
                _noteText = value;
            }
        }

        public DateTime timeCreated { get; }

        public DateTime timeModificated { get; set; }

        public Note()
        {
            timeCreated = DateTime.Now;
            _title = "Без названия";
            _noteText = "None"
        }

        public override string ToString()
        {
            return Title;
        }
    }
}
