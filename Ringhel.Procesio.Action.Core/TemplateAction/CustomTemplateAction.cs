using Ringhel.Procesio.Action.Core;
using Ringhel.Procesio.Action.Core.ActionDecorators;
using Ringhel.Procesio.Action.Core.Models;
using Ringhel.Procesio.Action.Core.Utils;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TestAction
{
    [ClassDecorator(Name = "Custom Template Action", Shape = ActionShape.Circle, Description = "Custom Template Action for adding 2 values", Classification = Classification.cat1)]
    [FEDecorator(Label = "Configuration Modal", Type = FeComponentType.Modal, Parent = "Config_Modal", Tab = "Input Tab")]
    public class MyCustomAction : IAction
    {

        #region Options
        private const string ConfigP1Options = "[{\"name\":\"1\",\"value\":\"1\"},{\"name\":\"2\",\"value\":\"2\"},{\"name\":\"3\",\"value\":\"3\"}]";
        private const string ConfigP2Options = "[{\"name\":\"my name3\",\"value\":\"my name value 3\"},{\"name\":\"my name4\",\"value\":\"my name value 4\"}]";

        private IEnumerable<OptionModel> ConfigP1OptionsList { get; } = new List<OptionModel>()
        {
            new OptionModel()
            {
                name = "Value 1",
                value = 1
            },
            new OptionModel(){
                name = "Value 2",
                value = 2
            },
            new OptionModel(){
                name = "Value 3",
                value = 3
            },
            new OptionModel(){
                name = "Value 4",
                value = 4
            },
            new OptionModel(){
                name = "Value 5",
                value = 5
            }
        };
        #endregion

        #region Properties
        [FEDecorator(Label = "First number to add", Type = FeComponentType.Select, Tab = "Input Tab", Options = "ConfigP1OptionsList")]
        [BEDecorator(IOProperty = Direction.Input)]
        [Validator(IsRequired = false)]
        public int Input1 { get; set; }

        [FEDecorator(Label = "Second number to add", Type = FeComponentType.Number, Tab = "Input Tab", DefaultValue = 0)]
        [BEDecorator(IOProperty = Direction.Input)]
        [Validator(IsRequired = false)]
        public int Input2 { get; set; }

        [FEDecorator(Label = "Result", Type = FeComponentType.Number, Tab = "Output Tab", DefaultValue = 1)]
        [BEDecorator(IOProperty = Direction.Output)]
        [Validator(IsRequired = false, Expects = ExpectedType.Number)]
        public int Output1 { get; set; }

        [FEDecorator(Label = "FE Config property 2", Type = FeComponentType.Select, Parent = "Config_Modal", Options = "ConfigP2Options")]
        [BEDecorator(IOProperty = Direction.Output)]
        [Validator(IsRequired = false, Expects = ExpectedType.String)]
        public string OutConfig2 { get; set; }
        #endregion

        #region Execute
        public async Task Execute()
        {
            Output1 = Input1 + Input2;
        }
        #endregion
    }
}
