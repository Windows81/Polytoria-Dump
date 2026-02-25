namespace UnityEngine;

[AttributeUsage(AttributeTargets::Method (64))]
[Token(Token = "0x200001F")]
public class GUITargetAttribute : Attribute
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000BD")]
	internal int displayMask; //Field offset: 0x10

	[Address(RVA = "0x19BE9D0", Offset = "0x19BDBD0", Length = "0x187")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Type), Member = "GetMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags)}, ReturnType = typeof(MethodInfo))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[RequiredByNativeCode]
	[Token(Token = "0x60001E6")]
	private static int GetGUITargetAttrValue(Type klass, string methodName) { }

}

