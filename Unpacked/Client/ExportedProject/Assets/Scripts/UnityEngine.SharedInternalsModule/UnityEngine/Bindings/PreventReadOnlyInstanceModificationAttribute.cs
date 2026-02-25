namespace UnityEngine.Bindings;

[AttributeUsage(AttributeTargets::Class (4), AllowMultiple = False, Inherited = False)]
[Token(Token = "0x200001A")]
[VisibleToOtherModules]
internal class PreventReadOnlyInstanceModificationAttribute : Attribute
{

	[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
	[CallerCount(Count = 83)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000036")]
	public PreventReadOnlyInstanceModificationAttribute() { }

}

