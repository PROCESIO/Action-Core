using Ringhel.Procesio.Action.Core.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ringhel.Procesio.Action.Core.ActionDecorators
{
    /// <summary>
    /// Attribute used to set some vital informations for FE
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Property, AllowMultiple = true)]
    public class FEDecoratorAttribute : Attribute
    {
        /// <summary>
        /// The parent tab to which the current property belongs
        /// </summary>
        public string Tab { get; set; }

        /// <summary>
        /// The parent property to which the current property belongs
        /// </summary>
        public string Parent { get; set; }

        /// <summary>
        /// Property label
        /// </summary>
        public string Label { get; set; }

        /// <summary>
        /// Name of the options list
        /// Each FE component may have a list of options
        /// </summary>
        public string Options { get; set; }

        /// <summary>
        /// The property default value converted to String
        /// </summary>
        public object DefaultValue { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public FeComponentType Type { get; set; }

        /// <summary>
        /// Property Row number. Used when showing the property in the Action configuration panel.
        /// If not set, all properties will be placed on the same default row.
        /// </summary>
        public int RowId { get; set; } = 0;

        /// <summary>
        /// Tooltip property. 
        /// </summary>
        public string Tooltip { get; set; }

        /// <summary>
        /// Minimum allowed value of the current type
        /// </summary>
        public object Min { get; set; }

        /// <summary>
        /// Maximum allowed value of the current type
        /// </summary>
        public object Max { get; set; }
    }
}
