using NUnit.Framework;

namespace OmniSharp.Tests.CompletionTests.AutoComplete
{
    public class DerivedTypeCompletions : CompletionTestBase
    {
        [Test]
        public void Should_complete_derived_types()
        {
            DisplayTextFor(
                @"public class A {
    public A() 
    {
        int n;
        n.GetHashCode$;
    }
}").ShouldContainOnly("GetHashCode()");
        }
    }
}