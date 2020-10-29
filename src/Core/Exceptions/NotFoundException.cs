using System;


namespace DotNetCms.Core.Exceptions
{
    public class NotFoundException<TIdentifier> : Exception
    {
        public NotFoundException(string objectType, TIdentifier id)
        {
            this.ObjectType = objectType;
            this.Id = id;
        }

        public string ObjectType { get; set; }
        public TIdentifier Id { get; set; }
    }
}