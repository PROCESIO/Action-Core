using Ringhel.Procesio.Action.Core;
using Ringhel.Procesio.Action.Core.ActionDecorators;
using Ringhel.Procesio.Action.Core.Models;
using Ringhel.Procesio.Action.Core.Utils;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TestAction
{
    [ClassDecorator(Name = "Custom Template Action", Shape = ActionShape.Circle, Description = "Custom Template Action for adding 2 values", Classification = Classification.cat1, Tooltip = "Test tooltip on Action")]
    [FEDecorator(Label = "Configuration Modal", Type = FeComponentType.Modal, Parent = "Config_Modal", Tab = "Input Tab", RowId = 1)]
    [FEDecorator(Label = "Configuration Modal", Type = FeComponentType.Side_pannel, Parent = "Side_Panel_Parent", Tab = "Input Tab", RowId = 2)]
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
        [FEDecorator(Label = "First number to add", Type = FeComponentType.Select, Tab = "Input Tab", Options = "ConfigP1OptionsList", RowId = 3, Tooltip ="Tooltip input1")]
        [BEDecorator(IOProperty = Direction.Input)]
        [Validator(IsRequired = false)]
        public int Input1 { get; set; }

        [FEDecorator(Label = "Second number to add", Type = FeComponentType.Number, Tab = "Input Tab", DefaultValue = 0, RowId = 4)]
        [BEDecorator(IOProperty = Direction.Input)]
        [Validator(IsRequired = false)]
        public int Input2 { get; set; }

        [FEDecorator(Label = "Result", Type = FeComponentType.Number, Tab = "Output Tab", DefaultValue = 1, RowId = 1)]
        [BEDecorator(IOProperty = Direction.Output)]
        [Validator(IsRequired = false, Expects = ExpectedType.Number)]
        public int Output1 { get; set; }

        [FEDecorator(Label = "FE Config property 2", Type = FeComponentType.Select, Parent = "Config_Modal", Options = "ConfigP2Options", RowId = 1)]
        [BEDecorator(IOProperty = Direction.Output)]
        [Validator(IsRequired = false, Expects = ExpectedType.String)]
        public string OutConfig2 { get; set; }

        #region List of numbers
        /// <summary>
        /// Please use IEnumerable for List properties.
        /// </summary>
        [FEDecorator(Label = "Number list", Type = FeComponentType.Number, Tab = "Input Tab", RowId = 5)]
        [BEDecorator(IOProperty = Direction.Input)]
        [Validator(IsRequired = true, Expects = ExpectedType.Number)]
        public IEnumerable<int> InputList { get; set; }

        [FEDecorator(Label = "Sum of list", Type = FeComponentType.Number, Tab = "Output Tab", RowId = 2)]
        [BEDecorator(IOProperty = Direction.Output)]
        [Validator(IsRequired = false)]
        public int OutputSum { get; set; }
        #endregion

        #region List of Files
        /// <summary>
        /// Please use IEnumerable for List properties.
        /// Remove IEnumerable when a single file is required.
        /// For output files, provide a valid MemoryStream in the FileModel.File object
        /// </summary>
        [FEDecorator(Label = "Map attachment", Type = FeComponentType.File, Parent = "Side_Panel_Parent", RowId = 1)]
        [BEDecorator(IOProperty = Direction.Input)]
        [Validator(IsRequired = false)]
        public IEnumerable<FileModel> FileList { get; set; }
        #endregion

        #region List of DataTypes
        ///// <summary>
        ///// This is for example and commented to prevent adding Newtonsoft.Json nuget in Action.Core library
        ///// </summary>
        //[FEDecorator(Label = "Custom data list input", Type = FeComponentType.DataType, Tab = "Input Tab", RowId = 6)]
        //[BEDecorator(IOProperty = Direction.Input)]
        //[Validator(IsRequired = false)]
        //public IEnumerable<JObject> CustomTypeList { get; set; }
        #endregion

        #endregion

        #region Execute
        public async Task Execute()
        {
            // Use of simple inputs
            Output1 = Input1 + Input2;

            // Use of numeric list:
            int result = 0;
            foreach(var inputValue in InputList)
            {
                result += inputValue;
            }
            OutputSum = result;

            // Use of files:
            foreach(var file in FileList)
            {
                _ = file.Name; // this is the file name if required.
                _ = file.File; // this is the file Stream which can be used to retrieve file content.

                // example of file stream use:
                using System.IO.Stream fileStream = file.File;
                _ = fileStream.Length;
            }

        }
        #endregion
    }
}
