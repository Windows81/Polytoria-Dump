namespace Unity.Properties;

[Token(Token = "0x200005C")]
public sealed class TypeConverter : MulticastDelegate
{

	[Address(RVA = "0x102B610", Offset = "0x102A810", Length = "0xB4")]
	[CallerCount(Count = 48)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000157")]
	public TypeConverter`2(object object, IntPtr method) { }

	[Address(RVA = "0x309260", Offset = "0x308460", Length = "0xF")]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000158")]
	public override TDestination Invoke(ref TSource value) { }

}

