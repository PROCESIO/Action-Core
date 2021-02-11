﻿using Ringhel.Procesio.Action.Core.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ringhel.Procesio.Action.Core.ActionDecorators
{
    /// <summary>
    /// Attribute that is used to define some basic informations about the action
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    public class ClassDecoratorAttribute : Attribute
    {
        /// <summary>
        /// Display name of the class
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Action Shape
        /// </summary>
        public ActionShape Shape { get; set; } = ActionShape.Circle;

        /// <summary>
        /// Action description
        /// </summary>
        public string Description { get; set; } = string.Empty;

        /// <summary>
        /// Action category
        /// </summary>
        public Category Category { get; set; }
    }
}
