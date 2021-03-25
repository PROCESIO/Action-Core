using System;
using System.Collections.Generic;
using System.Text;

namespace Ringhel.Procesio.Action.Core.ActionDecorators
{
    /// <summary>
    /// Attribute used to set some vital informations for FE
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    public class FETabDecoratorAttribute : Attribute
    {
        /// <summary>
        /// Tab where properties are found
        /// </summary>
        public string TabName { get; set; }

        /// <summary>
        /// Tab order number. It will be used to sort the action's tabs.
        /// If not used, All tabs will have the same order value = 0
        /// </summary>
        public int OrderId { get; set; } = 0;

    }
}
