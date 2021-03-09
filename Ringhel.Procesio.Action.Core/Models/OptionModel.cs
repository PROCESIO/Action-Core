using System;
using System.Collections.Generic;
using System.Text;

namespace Ringhel.Procesio.Action.Core.Models
{
    /// <summary>
    /// Model for the option of a FE component 
    /// </summary>
    public class OptionModel
    {
        /// <summary>
        /// Name that will be displayed for the current option
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// The actual value of the current option
        /// </summary>
        public object value { get; set; }
    }
}
