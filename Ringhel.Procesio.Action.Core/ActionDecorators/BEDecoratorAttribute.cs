﻿using Ringhel.Procesio.Action.Core.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ringhel.Procesio.Action.Core.ActionDecorators
{
    /// <summary>
    /// Attribute that is used when an action is executed
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
    public class BEDecoratorAttribute : Attribute
    {
        /// <summary>
        /// Specifies whether a property is input/output
        /// </summary>
        public Direction IOProperty { get; set; }
    }
}
