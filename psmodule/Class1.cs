using System;
using System.Management.Automation;

namespace psmodule
{
    [Cmdlet(VerbsCommon.Get, "HelloWorld")]
    public class GetHelloWorld : PSCmdlet
    {
        protected override void BeginProcessing()
        {
            WriteObject(classlibrary.Class1.HelloWorld());
        }
    }
}
