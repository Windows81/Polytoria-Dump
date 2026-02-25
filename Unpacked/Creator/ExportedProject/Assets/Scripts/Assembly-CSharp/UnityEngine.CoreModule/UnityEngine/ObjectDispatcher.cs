namespace UnityEngine;

[NativeHeader("Runtime/Misc/ObjectDispatcher.h")]
[RequiredByNativeCode]
[StaticAccessor("GetObjectDispatcher()", StaticAccessorType::Dot (0))]
[Token(Token = "0x2000105")]
internal sealed class ObjectDispatcher
{
	[CompilerGenerated]
	[Token(Token = "0x2000106")]
	private sealed class <>c
	{
		[Token(Token = "0x40004F2")]
		public static readonly <>c <>9; //Field offset: 0x0

		[Address(RVA = "0x19776F0", Offset = "0x19768F0", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600084E")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600084F")]
		public <>c() { }

		[Address(RVA = "0x1977160", Offset = "0x1976360", Length = "0x12F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(NativeArrayUnsafeUtility), Member = "ConvertExistingDataToNativeArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(int), typeof(Allocator)}, ReturnType = "Unity.Collections.NativeArray`1<T>")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000850")]
		internal void <.cctor>b__64_0(Object[] changed, IntPtr changedID, IntPtr destroyedID, int changedCount, int destroyedCount, Action<TypeDispatchData> callback) { }

		[Address(RVA = "0x1977290", Offset = "0x1976490", Length = "0x1E9")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(NativeArrayUnsafeUtility), Member = "ConvertExistingDataToNativeArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(int), typeof(Allocator)}, ReturnType = "Unity.Collections.NativeArray`1<T>")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000851")]
		internal void <.cctor>b__64_1(IntPtr transformed, IntPtr parents, IntPtr localToWorldMatrices, IntPtr positions, IntPtr rotations, IntPtr scales, int count, Action<TransformDispatchData> callback) { }

	}

	[Token(Token = "0x40004F0")]
	private static Action<Object[], IntPtr, IntPtr, Int32, Int32, Action`1<TypeDispatchData>> s_TypeDispatch; //Field offset: 0x0
	[Token(Token = "0x40004F1")]
	private static Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, Int32, Action`1<TransformDispatchData>> s_TransformDispatch; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40004EF")]
	private IntPtr m_Ptr; //Field offset: 0x10

	[Address(RVA = "0x1966750", Offset = "0x1965950", Length = "0x141")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Action`6), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Action`8), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Token(Token = "0x600084D")]
	private static ObjectDispatcher() { }

}

