namespace UnityEngine.Rendering;

[NativeHeader("Runtime/Camera/GPUDrivenProcessor.h")]
[RequiredByNativeCode]
[Token(Token = "0x20002E9")]
internal class GPUDrivenProcessor
{
	[CompilerGenerated]
	[Token(Token = "0x20002EA")]
	private sealed class <>c
	{
		[Token(Token = "0x40008C2")]
		public static readonly <>c <>9; //Field offset: 0x0

		[Address(RVA = "0x1992130", Offset = "0x1991330", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000E35")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000E36")]
		public <>c() { }

		[Address(RVA = "0x1990DA0", Offset = "0x198FFA0", Length = "0x7B0")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(NativeArrayUnsafeUtility), Member = "ConvertExistingDataToNativeArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(int), typeof(Allocator)}, ReturnType = "Unity.Collections.NativeArray`1<T>")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000E37")]
		internal void <.cctor>b__35_0(in GPUDrivenRendererGroupDataNative nativeData, List<Mesh> meshes, List<Material> materials, GPUDrivenRendererDataCallback callback) { }

		[Address(RVA = "0x1991560", Offset = "0x1990760", Length = "0x35F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(NativeArrayUnsafeUtility), Member = "ConvertExistingDataToNativeArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(int), typeof(Allocator)}, ReturnType = "Unity.Collections.NativeArray`1<T>")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000E38")]
		internal void <.cctor>b__35_1(in GPUDrivenLODGroupDataNative nativeData, GPUDrivenLODGroupDataCallback callback) { }

	}

	[Token(Token = "0x40008C0")]
	private static GPUDrivenRendererDataNativeCallback s_NativeRendererCallback; //Field offset: 0x0
	[Token(Token = "0x40008C1")]
	private static GPUDrivenLODGroupDataNativeCallback s_NativeLODGroupCallback; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40008BF")]
	internal IntPtr m_Ptr; //Field offset: 0x10

	[Address(RVA = "0x1980DD0", Offset = "0x197FFD0", Length = "0x250")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000E34")]
	private static GPUDrivenProcessor() { }

}

