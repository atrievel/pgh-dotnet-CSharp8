namespace DotNetLightningTalks
{
    interface IDefaultInterface
    {
        void DoSomething();
        int DoSomethingElse();
        public string DefaultInterfaceImplementation() => "This is the default behavior";
    }
    class ClassA : IDefaultInterface
    {
        public void DoSomething() { }

        public int DoSomethingElse() => 100;
    }

    class ClassB : IDefaultInterface
    {
        public void DoSomething() { }

        public int DoSomethingElse() => 500;

        public string DefaultInterfaceImplementation() => "Override default";
    }
}