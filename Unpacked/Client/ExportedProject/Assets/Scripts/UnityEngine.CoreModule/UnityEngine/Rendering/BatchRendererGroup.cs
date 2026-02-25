namespace UnityEngine.Rendering;

[NativeHeader("Runtime/Camera/BatchRendererGroup.h")]
[NativeHeader("Runtime/Math/Matrix4x4.h")]
[RequiredByNativeCode]
[Token(Token = "0x20002E1")]
public class BatchRendererGroup
{
	[Token(Token = "0x20002E3")]
	internal sealed class OnFinishedCulling : MulticastDelegate
	{

		[Address(RVA = "0x391F20", Offset = "0x391120", Length = "0xA6")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000E28")]
		public OnFinishedCulling(object object, IntPtr method) { }

		[Address(RVA = "0x309260", Offset = "0x308460", Length = "0xF")]
		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000E29")]
		public override void Invoke(IntPtr customCullingResult) { }

	}

	[Token(Token = "0x20002E2")]
	internal sealed class OnPerformCulling : MulticastDelegate
	{

		[Address(RVA = "0x1985910", Offset = "0x1984B10", Length = "0x125")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE9B0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE9C0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6000E26")]
		public OnPerformCulling(object object, IntPtr method) { }

		[Address(RVA = "0x1985810", Offset = "0x1984A10", Length = "0xFD")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000E27")]
		public override JobHandle Invoke(BatchRendererGroup rendererGroup, BatchCullingContext cullingContext, BatchCullingOutput cullingOutput, IntPtr userContext) { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40008BC")]
	private IntPtr m_GroupHandle; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40008BD")]
	private OnPerformCulling m_PerformCulling; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40008BE")]
	private OnFinishedCulling m_FinishedCulling; //Field offset: 0x20

	[Address(RVA = "0x197B3B0", Offset = "0x197A5B0", Length = "0x5D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "LogException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[RequiredByNativeCode]
	[Token(Token = "0x6000E25")]
	private static void InvokeOnFinishedCulling(BatchRendererGroup group, IntPtr customCullingResult) { }

	[Address(RVA = "0x197B410", Offset = "0x197A610", Length = "0x398")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NativeArrayUnsafeUtility), Member = "ConvertExistingDataToNativeArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(int), typeof(Allocator)}, ReturnType = "Unity.Collections.NativeArray`1<T>")]
	[Calls(Type = typeof(NativeArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Allocator), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JobHandle), Member = "ScheduleBatchedJobs", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 1)]
	[RequiredByNativeCode]
	[Token(Token = "0x6000E24")]
	private static void InvokeOnPerformCulling(BatchRendererGroup group, ref BatchRendererCullingOutput context, ref LODParameters lodParameters, IntPtr userContext) { }

}

