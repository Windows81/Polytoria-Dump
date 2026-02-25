namespace Unity.Hierarchy;

[NativeHeader("Modules/HierarchyCore/HierarchyCommandListBindings.h")]
[NativeHeader("Modules/HierarchyCore/Public/HierarchyCommandList.h")]
[RequiredByNativeCode(GenerateProxy = True)]
[Token(Token = "0x2000018")]
public sealed class HierarchyCommandList : IDisposable
{
	[Token(Token = "0x2000019")]
	public static class BindingsMarshaller
	{

		[Address(RVA = "0x7CE590", Offset = "0x7CD790", Length = "0x17")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000085")]
		public static IntPtr ConvertToNative(HierarchyCommandList cmdList) { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000033")]
	private IntPtr m_Ptr; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000034")]
	private readonly bool m_IsOwner; //Field offset: 0x18

	[Address(RVA = "0x1945AC0", Offset = "0x1944CC0", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600007E")]
	private HierarchyCommandList(IntPtr nativePtr) { }

	[Address(RVA = "0x1996300", Offset = "0x1995500", Length = "0x68")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(GCHandle), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(GCHandle))]
	[CallsDeduplicatedMethods(Count = 2)]
	[RequiredByNativeCode]
	[Token(Token = "0x6000084")]
	private static IntPtr CreateCommandList(IntPtr nativePtr) { }

	[Address(RVA = "0x1996370", Offset = "0x1995570", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("HierarchyCommandListBindings::Destroy", IsThreadSafe = True)]
	[Token(Token = "0x6000083")]
	private static void Destroy(IntPtr nativePtr) { }

	[Address(RVA = "0x1996410", Offset = "0x1995610", Length = "0x90")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000080")]
	public override void Dispose() { }

	[Address(RVA = "0x19963B0", Offset = "0x19955B0", Length = "0x56")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000081")]
	private void Dispose(bool disposing) { }

	[Address(RVA = "0x19964A0", Offset = "0x19956A0", Length = "0x9B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600007F")]
	protected virtual void Finalize() { }

	[Address(RVA = "0x1996540", Offset = "0x1995740", Length = "0xC6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GCHandle), Member = "GetTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000082")]
	internal static HierarchyCommandList FromIntPtr(IntPtr handlePtr) { }

}

