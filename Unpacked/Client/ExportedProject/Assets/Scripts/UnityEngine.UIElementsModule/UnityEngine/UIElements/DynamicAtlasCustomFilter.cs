namespace UnityEngine.UIElements;

[Token(Token = "0x2000007")]
public sealed class DynamicAtlasCustomFilter : MulticastDelegate
{

	[Address(RVA = "0x100F800", Offset = "0x100EA00", Length = "0xB5")]
	[CallerCount(Count = 24)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000012")]
	public DynamicAtlasCustomFilter(object object, IntPtr method) { }

	[Address(RVA = "0x335340", Offset = "0x334540", Length = "0xF")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000013")]
	public override bool Invoke(Texture2D texture, ref DynamicAtlasFilters filtersToApply) { }

}

