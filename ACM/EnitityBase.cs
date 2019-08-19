﻿namespace ACM
{
    public enum EntityStateOption
    {
        Active,
        Deleted
    }
    public abstract class EnitityBase
    {
        public EntityStateOption EntityState { get; set; }
        public bool HasChanges { get; set; }
        public bool IsNew { get; private set; }
        public bool IsValid => Validate();

        public abstract bool Validate();
    }
}
