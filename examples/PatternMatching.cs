using System;

namespace DotNetLightningTalks
{  
    public class PatternMatching
    {   
        public enum Console
        {
            Xbox,
            Playstation,
            Switch,
            Genesis
        }

        public string OldSwitchMethod(Console consoleName) 
        {
            switch (consoleName)
            {
                case Console.Xbox:
                    return "Microsoft";
                case Console.Playstation:
                    return "Sony";
                case Console.Switch:
                    return "Nintendo";
                case Console.Genesis:
                    return "Sega";
                default:
                    throw new ArgumentException(message: "Invalid console type", paramName: nameof(consoleName));
            }
        }

        public string NewSwitchMethod(Console consoleName) =>
            consoleName switch
            {
                Console.Xbox => "Microsoft",
                Console.Playstation => "Sony",
                Console.Switch => "Nintendo",
                Console.Genesis => "Sega",
                _  => new ArgumentException(message: "Invalid console type", paramName: nameof(consoleName))
            };

        private class ExampleClass 
        {
            public int IntProperty { get; set; }
        }

        public string PropertyPattern(ExampleClass example) => 
            somePattern switch
            {
                { example.IntProperty < 0 } =>  "Negative integer",
                { example.IntProperty == 0 } => "Zero",
                { example.IntProperty > 0 } => "Postitve integer",
                _ => "Math is broken"
            };
    }
}