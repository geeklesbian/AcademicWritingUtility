using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademicWritingUtility.Domain.Models
{
    public interface ICitationType : IBaseClass
    {
        string Name { get; }
        int YearPublished { get; }
        string DOi { get; }
        string Fields { get; } //json string
        string GetFields<TEntity>() where TEntity : class, ICitationType, new();
        TEntity GetCitation<TEntity>(string data) where TEntity : class, ICitationType, new();
        TEntity New<TEntity>(string values) where TEntity : class, IInType<TEntity>, new();
    }
    public interface IInType<TEntity> : ICitationType
    {
        TEntity New(string values);
    }
    public abstract class CitationType : BaseClass, ICitationType
    {
        public string Name { get; private set; }
        public int YearPublished { get; private set; }
        public string DOI { get; private set; }
        public string Fields { get; private set; } // JsonString

        // TODO: How-to make fields of citation type dynamic
        //public ValueObject<string> Fields { get; private set; }


        public virtual string GetFields<TEntity>()
           where TEntity : class, ICitationType, new()
        {
            return JsonConvert.SerializeObject(new TEntity());
        }
        public TEntity GetCitation<TEntity>(string data)
            where TEntity : class, ICitationType, new()
        {
            return JsonConvert.DeserializeObject<TEntity>(data);
        }
        public TEntity New<TEntity>(string values)
             where TEntity : class, IInType<TEntity>, new()
        {
            TEntity e = new TEntity();
            return e.New(values);
        }
       
        protected CitationType() : base() { }
        protected CitationType(string name, int yearPublished, string fields, string doi = "") : base() 
        {
            SetValues(name, yearPublished, fields, doi);
        }
        protected CitationType(Guid id, string name, int yearPublished, string fields, string doi = "") : base(id)
        {
            SetValues(name, yearPublished, fields, doi);
        }
        private void SetValues(string name, int yearPublished, string fields, string doi)
        {
            Name = name;
            YearPublished = yearPublished;
            DOI = doi;
            Fields = fields;
        }
    }
}
