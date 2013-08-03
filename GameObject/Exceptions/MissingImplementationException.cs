﻿using System;

namespace GameObject.Exceptions
{
    class MissingImplementationException : Exception
    {
        private readonly Type _type;

        public MissingImplementationException(Type type)
        {
            _type = type;
        }

        public override string Message
        {
            get { return String.Format("There is no concrete implementation for type {0}.", _type); }
        }
    }
}
