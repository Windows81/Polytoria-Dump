namespace UnityEngine.Experimental.GlobalIllumination;

[Token(Token = "0x2000312")]
public static class Lightmapping
{
	[CompilerGenerated]
	[Token(Token = "0x2000314")]
	private sealed class <>c
	{
		[Token(Token = "0x40009F5")]
		public static readonly <>c <>9; //Field offset: 0x0

		[Address(RVA = "0x19920C0", Offset = "0x19912C0", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000ED6")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000ED7")]
		public <>c() { }

		[Address(RVA = "0x19918C0", Offset = "0x1990AC0", Length = "0x596")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Light), Member = "get_type", ReturnType = typeof(LightType))]
		[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
		[Calls(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), typeof(DiscLight&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), typeof(Cookie&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), typeof(RectangleLight&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), typeof(PointLight&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), typeof(DirectionalLight&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), typeof(SpotLight&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000ED8")]
		internal void <.cctor>b__7_0(Light[] requests, NativeArray<LightDataGI> lightsOutput) { }

	}

	[Token(Token = "0x2000313")]
	internal sealed class RequestLightsDelegate : MulticastDelegate
	{

		[Address(RVA = "0x198C120", Offset = "0x198B320", Length = "0xB5")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6000ED4")]
		public RequestLightsDelegate(object object, IntPtr method) { }

		[Address(RVA = "0xA30A40", Offset = "0xA2FC40", Length = "0x25")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000ED5")]
		public override void Invoke(Light[] requests, NativeArray<LightDataGI> lightsOutput) { }

	}

	[RequiredByNativeCode]
	[Token(Token = "0x40009F3")]
	private static readonly RequestLightsDelegate s_DefaultDelegate; //Field offset: 0x0
	[RequiredByNativeCode]
	[Token(Token = "0x40009F4")]
	private static RequestLightsDelegate s_RequestLightsDelegate; //Field offset: 0x8

	[Address(RVA = "0x1984C20", Offset = "0x1983E20", Length = "0x187")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000ED3")]
	private static Lightmapping() { }

	[Address(RVA = "0x19849F0", Offset = "0x1983BF0", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[RequiredByNativeCode]
	[Token(Token = "0x6000ED0")]
	public static RequestLightsDelegate GetDelegate() { }

	[Address(RVA = "0x1984A40", Offset = "0x1983C40", Length = "0xD1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NativeArrayUnsafeUtility), Member = "ConvertExistingDataToNativeArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(int), typeof(Allocator)}, ReturnType = "Unity.Collections.NativeArray`1<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[RequiredByNativeCode]
	[Token(Token = "0x6000ED2")]
	internal static void RequestLights(Light[] lights, IntPtr outLightsPtr, int outLightsCount) { }

	[Address(RVA = "0x1984B20", Offset = "0x1983D20", Length = "0x65")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[RequiredByNativeCode]
	[Token(Token = "0x6000ED1")]
	public static void ResetDelegate() { }

	[Address(RVA = "0x1984B90", Offset = "0x1983D90", Length = "0x8E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[RequiredByNativeCode]
	[Token(Token = "0x6000ECF")]
	public static void SetDelegate(RequestLightsDelegate del) { }

}

