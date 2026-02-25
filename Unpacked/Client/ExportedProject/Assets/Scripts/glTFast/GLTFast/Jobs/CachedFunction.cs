namespace GLTFast.Jobs;

[BurstCompile]
[Token(Token = "0x20000F0")]
internal static class CachedFunction
{
	[Token(Token = "0x20000F2")]
	[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
	internal sealed class GetFloat3Delegate : MulticastDelegate
	{

		[Address(RVA = "0x53F5F0", Offset = "0x53E7F0", Length = "0xB5")]
		[CallerCount(Count = 13)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x60002F3")]
		public GetFloat3Delegate(object object, IntPtr method) { }

		[Address(RVA = "0x335340", Offset = "0x334540", Length = "0xF")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002F4")]
		public override void Invoke(float3* destination, Void* src) { }

	}

	[Token(Token = "0x20000FE")]
	public static class GetFloat3Float_000003B8$BurstDirectCall
	{
		[Token(Token = "0x40003BF")]
		private static IntPtr Pointer; //Field offset: 0x0

		[Address(RVA = "0x108CB60", Offset = "0x108BD60", Length = "0x17A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(BurstCompiler), Member = "CompileFunctionPointer", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "Unity.Burst.FunctionPointer`1<T>")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6000311")]
		private static IntPtr GetFunctionPointer() { }

		[Address(RVA = "0x108C9D0", Offset = "0x108BBD0", Length = "0x184")]
		[BurstDiscard]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(BurstCompiler), Member = "CompileFunctionPointer", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "Unity.Burst.FunctionPointer`1<T>")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6000310")]
		private static void GetFunctionPointerDiscard(ref IntPtr unnamed_param_0) { }

		[Address(RVA = "0x108CCE0", Offset = "0x108BEE0", Length = "0x208")]
		[CalledBy(Type = typeof(CachedFunction), Member = "GetFloat3Float", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3*), typeof(Void*)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(BurstCompiler), Member = "get_IsEnabled", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(BurstCompiler), Member = "CompileFunctionPointer", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "Unity.Burst.FunctionPointer`1<T>")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000312")]
		public static void Invoke(float3* destination, Void* src) { }

	}

	[Token(Token = "0x20000FD")]
	[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
	public sealed class GetFloat3Float_000003B8$PostfixBurstDelegate : MulticastDelegate
	{

		[Address(RVA = "0x53F5F0", Offset = "0x53E7F0", Length = "0xB5")]
		[CallerCount(Count = 13)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x600030E")]
		public GetFloat3Float_000003B8$PostfixBurstDelegate(object unnamed_param_0, IntPtr unnamed_param_1) { }

		[Address(RVA = "0x335340", Offset = "0x334540", Length = "0xF")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600030F")]
		public override void Invoke(float3* destination, Void* src) { }

	}

	[Token(Token = "0x2000104")]
	public static class GetFloat3Int16_000003BB$BurstDirectCall
	{
		[Token(Token = "0x40003C2")]
		private static IntPtr Pointer; //Field offset: 0x0

		[Address(RVA = "0x108D390", Offset = "0x108C590", Length = "0x17A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(BurstCompiler), Member = "CompileFunctionPointer", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "Unity.Burst.FunctionPointer`1<T>")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6000320")]
		private static IntPtr GetFunctionPointer() { }

		[Address(RVA = "0x108D200", Offset = "0x108C400", Length = "0x184")]
		[BurstDiscard]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(BurstCompiler), Member = "CompileFunctionPointer", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "Unity.Burst.FunctionPointer`1<T>")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x600031F")]
		private static void GetFunctionPointerDiscard(ref IntPtr unnamed_param_0) { }

		[Address(RVA = "0x108D510", Offset = "0x108C710", Length = "0x21D")]
		[CalledBy(Type = typeof(CachedFunction), Member = "GetFloat3Int16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3*), typeof(Void*)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(BurstCompiler), Member = "get_IsEnabled", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(BurstCompiler), Member = "CompileFunctionPointer", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "Unity.Burst.FunctionPointer`1<T>")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000321")]
		public static void Invoke(float3* destination, Void* src) { }

	}

	[Token(Token = "0x2000103")]
	[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
	public sealed class GetFloat3Int16_000003BB$PostfixBurstDelegate : MulticastDelegate
	{

		[Address(RVA = "0x53F5F0", Offset = "0x53E7F0", Length = "0xB5")]
		[CallerCount(Count = 13)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x600031D")]
		public GetFloat3Int16_000003BB$PostfixBurstDelegate(object unnamed_param_0, IntPtr unnamed_param_1) { }

		[Address(RVA = "0x335340", Offset = "0x334540", Length = "0xF")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600031E")]
		public override void Invoke(float3* destination, Void* src) { }

	}

	[Token(Token = "0x200010E")]
	public static class GetFloat3Int16Normalized_000003C0$BurstDirectCall
	{
		[Token(Token = "0x40003C7")]
		private static IntPtr Pointer; //Field offset: 0x0

		[Address(RVA = "0x108D080", Offset = "0x108C280", Length = "0x17A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(BurstCompiler), Member = "CompileFunctionPointer", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "Unity.Burst.FunctionPointer`1<T>")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6000339")]
		private static IntPtr GetFunctionPointer() { }

		[Address(RVA = "0x108CEF0", Offset = "0x108C0F0", Length = "0x184")]
		[BurstDiscard]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(BurstCompiler), Member = "CompileFunctionPointer", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "Unity.Burst.FunctionPointer`1<T>")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6000338")]
		private static void GetFunctionPointerDiscard(ref IntPtr unnamed_param_0) { }

		[Address(RVA = "0x10883E0", Offset = "0x10875E0", Length = "0x1F0")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(BurstCompiler), Member = "get_IsEnabled", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(BurstCompiler), Member = "CompileFunctionPointer", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "Unity.Burst.FunctionPointer`1<T>")]
		[Calls(Type = typeof(CachedFunction), Member = "GetFloat3Int16Normalized$BurstManaged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3*), typeof(Void*)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600033A")]
		public static void Invoke(float3* destination, Void* src) { }

	}

	[Token(Token = "0x200010D")]
	[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
	public sealed class GetFloat3Int16Normalized_000003C0$PostfixBurstDelegate : MulticastDelegate
	{

		[Address(RVA = "0x53F5F0", Offset = "0x53E7F0", Length = "0xB5")]
		[CallerCount(Count = 13)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000336")]
		public GetFloat3Int16Normalized_000003C0$PostfixBurstDelegate(object unnamed_param_0, IntPtr unnamed_param_1) { }

		[Address(RVA = "0x335340", Offset = "0x334540", Length = "0xF")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000337")]
		public override void Invoke(float3* destination, Void* src) { }

	}

	[Token(Token = "0x2000100")]
	public static class GetFloat3Int8_000003B9$BurstDirectCall
	{
		[Token(Token = "0x40003C0")]
		private static IntPtr Pointer; //Field offset: 0x0

		[Address(RVA = "0x108DBD0", Offset = "0x108CDD0", Length = "0x17A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(BurstCompiler), Member = "CompileFunctionPointer", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "Unity.Burst.FunctionPointer`1<T>")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6000316")]
		private static IntPtr GetFunctionPointer() { }

		[Address(RVA = "0x108DA40", Offset = "0x108CC40", Length = "0x184")]
		[BurstDiscard]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(BurstCompiler), Member = "CompileFunctionPointer", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "Unity.Burst.FunctionPointer`1<T>")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6000315")]
		private static void GetFunctionPointerDiscard(ref IntPtr unnamed_param_0) { }

		[Address(RVA = "0x108DD50", Offset = "0x108CF50", Length = "0x21D")]
		[CalledBy(Type = typeof(CachedFunction), Member = "GetFloat3Int8", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3*), typeof(Void*)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(BurstCompiler), Member = "get_IsEnabled", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(BurstCompiler), Member = "CompileFunctionPointer", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "Unity.Burst.FunctionPointer`1<T>")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000317")]
		public static void Invoke(float3* destination, Void* src) { }

	}

	[Token(Token = "0x20000FF")]
	[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
	public sealed class GetFloat3Int8_000003B9$PostfixBurstDelegate : MulticastDelegate
	{

		[Address(RVA = "0x53F5F0", Offset = "0x53E7F0", Length = "0xB5")]
		[CallerCount(Count = 13)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000313")]
		public GetFloat3Int8_000003B9$PostfixBurstDelegate(object unnamed_param_0, IntPtr unnamed_param_1) { }

		[Address(RVA = "0x335340", Offset = "0x334540", Length = "0xF")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000314")]
		public override void Invoke(float3* destination, Void* src) { }

	}

	[Token(Token = "0x200010A")]
	public static class GetFloat3Int8Normalized_000003BE$BurstDirectCall
	{
		[Token(Token = "0x40003C5")]
		private static IntPtr Pointer; //Field offset: 0x0

		[Address(RVA = "0x108D8C0", Offset = "0x108CAC0", Length = "0x17A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(BurstCompiler), Member = "CompileFunctionPointer", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "Unity.Burst.FunctionPointer`1<T>")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x600032F")]
		private static IntPtr GetFunctionPointer() { }

		[Address(RVA = "0x108D730", Offset = "0x108C930", Length = "0x184")]
		[BurstDiscard]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(BurstCompiler), Member = "CompileFunctionPointer", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "Unity.Burst.FunctionPointer`1<T>")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x600032E")]
		private static void GetFunctionPointerDiscard(ref IntPtr unnamed_param_0) { }

		[Address(RVA = "0x1088640", Offset = "0x1087840", Length = "0x1F0")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(BurstCompiler), Member = "get_IsEnabled", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(BurstCompiler), Member = "CompileFunctionPointer", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "Unity.Burst.FunctionPointer`1<T>")]
		[Calls(Type = typeof(CachedFunction), Member = "GetFloat3Int8Normalized$BurstManaged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3*), typeof(Void*)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000330")]
		public static void Invoke(float3* destination, Void* src) { }

	}

	[Token(Token = "0x2000109")]
	[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
	public sealed class GetFloat3Int8Normalized_000003BE$PostfixBurstDelegate : MulticastDelegate
	{

		[Address(RVA = "0x53F5F0", Offset = "0x53E7F0", Length = "0xB5")]
		[CallerCount(Count = 13)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x600032C")]
		public GetFloat3Int8Normalized_000003BE$PostfixBurstDelegate(object unnamed_param_0, IntPtr unnamed_param_1) { }

		[Address(RVA = "0x335340", Offset = "0x334540", Length = "0xF")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600032D")]
		public override void Invoke(float3* destination, Void* src) { }

	}

	[Token(Token = "0x2000106")]
	public static class GetFloat3UInt16_000003BC$BurstDirectCall
	{
		[Token(Token = "0x40003C3")]
		private static IntPtr Pointer; //Field offset: 0x0

		[Address(RVA = "0x108E650", Offset = "0x108D850", Length = "0x17A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(BurstCompiler), Member = "CompileFunctionPointer", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "Unity.Burst.FunctionPointer`1<T>")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6000325")]
		private static IntPtr GetFunctionPointer() { }

		[Address(RVA = "0x108E4C0", Offset = "0x108D6C0", Length = "0x184")]
		[BurstDiscard]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(BurstCompiler), Member = "CompileFunctionPointer", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "Unity.Burst.FunctionPointer`1<T>")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6000324")]
		private static void GetFunctionPointerDiscard(ref IntPtr unnamed_param_0) { }

		[Address(RVA = "0x108E7D0", Offset = "0x108D9D0", Length = "0x21D")]
		[CalledBy(Type = typeof(CachedFunction), Member = "GetFloat3UInt16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3*), typeof(Void*)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(BurstCompiler), Member = "get_IsEnabled", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(BurstCompiler), Member = "CompileFunctionPointer", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "Unity.Burst.FunctionPointer`1<T>")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000326")]
		public static void Invoke(float3* destination, Void* src) { }

	}

	[Token(Token = "0x2000105")]
	[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
	public sealed class GetFloat3UInt16_000003BC$PostfixBurstDelegate : MulticastDelegate
	{

		[Address(RVA = "0x53F5F0", Offset = "0x53E7F0", Length = "0xB5")]
		[CallerCount(Count = 13)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000322")]
		public GetFloat3UInt16_000003BC$PostfixBurstDelegate(object unnamed_param_0, IntPtr unnamed_param_1) { }

		[Address(RVA = "0x335340", Offset = "0x334540", Length = "0xF")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000323")]
		public override void Invoke(float3* destination, Void* src) { }

	}

	[Token(Token = "0x2000110")]
	public static class GetFloat3UInt16Normalized_000003C1$BurstDirectCall
	{
		[Token(Token = "0x40003C8")]
		private static IntPtr Pointer; //Field offset: 0x0

		[Address(RVA = "0x108E100", Offset = "0x108D300", Length = "0x17A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(BurstCompiler), Member = "CompileFunctionPointer", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "Unity.Burst.FunctionPointer`1<T>")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x600033E")]
		private static IntPtr GetFunctionPointer() { }

		[Address(RVA = "0x108DF70", Offset = "0x108D170", Length = "0x184")]
		[BurstDiscard]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(BurstCompiler), Member = "CompileFunctionPointer", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "Unity.Burst.FunctionPointer`1<T>")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x600033D")]
		private static void GetFunctionPointerDiscard(ref IntPtr unnamed_param_0) { }

		[Address(RVA = "0x108E280", Offset = "0x108D480", Length = "0x231")]
		[CalledBy(Type = typeof(CachedFunction), Member = "GetFloat3UInt16Normalized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3*), typeof(Void*)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(BurstCompiler), Member = "get_IsEnabled", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(BurstCompiler), Member = "CompileFunctionPointer", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "Unity.Burst.FunctionPointer`1<T>")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600033F")]
		public static void Invoke(float3* destination, Void* src) { }

	}

	[Token(Token = "0x200010F")]
	[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
	public sealed class GetFloat3UInt16Normalized_000003C1$PostfixBurstDelegate : MulticastDelegate
	{

		[Address(RVA = "0x53F5F0", Offset = "0x53E7F0", Length = "0xB5")]
		[CallerCount(Count = 13)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x600033B")]
		public GetFloat3UInt16Normalized_000003C1$PostfixBurstDelegate(object unnamed_param_0, IntPtr unnamed_param_1) { }

		[Address(RVA = "0x335340", Offset = "0x334540", Length = "0xF")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600033C")]
		public override void Invoke(float3* destination, Void* src) { }

	}

	[Token(Token = "0x2000108")]
	public static class GetFloat3UInt32_000003BD$BurstDirectCall
	{
		[Token(Token = "0x40003C4")]
		private static IntPtr Pointer; //Field offset: 0x0

		[Address(RVA = "0x108F0D0", Offset = "0x108E2D0", Length = "0x17A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(BurstCompiler), Member = "CompileFunctionPointer", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "Unity.Burst.FunctionPointer`1<T>")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x600032A")]
		private static IntPtr GetFunctionPointer() { }

		[Address(RVA = "0x108EF40", Offset = "0x108E140", Length = "0x184")]
		[BurstDiscard]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(BurstCompiler), Member = "CompileFunctionPointer", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "Unity.Burst.FunctionPointer`1<T>")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6000329")]
		private static void GetFunctionPointerDiscard(ref IntPtr unnamed_param_0) { }

		[Address(RVA = "0x108F250", Offset = "0x108E450", Length = "0x226")]
		[CalledBy(Type = typeof(CachedFunction), Member = "GetFloat3UInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3*), typeof(Void*)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(BurstCompiler), Member = "get_IsEnabled", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(BurstCompiler), Member = "CompileFunctionPointer", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "Unity.Burst.FunctionPointer`1<T>")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600032B")]
		public static void Invoke(float3* destination, Void* src) { }

	}

	[Token(Token = "0x2000107")]
	[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
	public sealed class GetFloat3UInt32_000003BD$PostfixBurstDelegate : MulticastDelegate
	{

		[Address(RVA = "0x53F5F0", Offset = "0x53E7F0", Length = "0xB5")]
		[CallerCount(Count = 13)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000327")]
		public GetFloat3UInt32_000003BD$PostfixBurstDelegate(object unnamed_param_0, IntPtr unnamed_param_1) { }

		[Address(RVA = "0x335340", Offset = "0x334540", Length = "0xF")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000328")]
		public override void Invoke(float3* destination, Void* src) { }

	}

	[Token(Token = "0x2000112")]
	public static class GetFloat3UInt32Normalized_000003C2$BurstDirectCall
	{
		[Token(Token = "0x40003C9")]
		private static IntPtr Pointer; //Field offset: 0x0

		[Address(RVA = "0x108EB80", Offset = "0x108DD80", Length = "0x17A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(BurstCompiler), Member = "CompileFunctionPointer", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "Unity.Burst.FunctionPointer`1<T>")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6000343")]
		private static IntPtr GetFunctionPointer() { }

		[Address(RVA = "0x108E9F0", Offset = "0x108DBF0", Length = "0x184")]
		[BurstDiscard]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(BurstCompiler), Member = "CompileFunctionPointer", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "Unity.Burst.FunctionPointer`1<T>")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6000342")]
		private static void GetFunctionPointerDiscard(ref IntPtr unnamed_param_0) { }

		[Address(RVA = "0x108ED00", Offset = "0x108DF00", Length = "0x23A")]
		[CalledBy(Type = typeof(CachedFunction), Member = "GetFloat3UInt32Normalized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3*), typeof(Void*)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(BurstCompiler), Member = "get_IsEnabled", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(BurstCompiler), Member = "CompileFunctionPointer", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "Unity.Burst.FunctionPointer`1<T>")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000344")]
		public static void Invoke(float3* destination, Void* src) { }

	}

	[Token(Token = "0x2000111")]
	[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
	public sealed class GetFloat3UInt32Normalized_000003C2$PostfixBurstDelegate : MulticastDelegate
	{

		[Address(RVA = "0x53F5F0", Offset = "0x53E7F0", Length = "0xB5")]
		[CallerCount(Count = 13)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000340")]
		public GetFloat3UInt32Normalized_000003C2$PostfixBurstDelegate(object unnamed_param_0, IntPtr unnamed_param_1) { }

		[Address(RVA = "0x335340", Offset = "0x334540", Length = "0xF")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000341")]
		public override void Invoke(float3* destination, Void* src) { }

	}

	[Token(Token = "0x2000102")]
	public static class GetFloat3UInt8_000003BA$BurstDirectCall
	{
		[Token(Token = "0x40003C1")]
		private static IntPtr Pointer; //Field offset: 0x0

		[Address(RVA = "0x108FB60", Offset = "0x108ED60", Length = "0x17A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(BurstCompiler), Member = "CompileFunctionPointer", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "Unity.Burst.FunctionPointer`1<T>")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x600031B")]
		private static IntPtr GetFunctionPointer() { }

		[Address(RVA = "0x108F9D0", Offset = "0x108EBD0", Length = "0x184")]
		[BurstDiscard]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(BurstCompiler), Member = "CompileFunctionPointer", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "Unity.Burst.FunctionPointer`1<T>")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x600031A")]
		private static void GetFunctionPointerDiscard(ref IntPtr unnamed_param_0) { }

		[Address(RVA = "0x108FCE0", Offset = "0x108EEE0", Length = "0x21D")]
		[CalledBy(Type = typeof(CachedFunction), Member = "GetFloat3UInt8", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3*), typeof(Void*)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(BurstCompiler), Member = "get_IsEnabled", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(BurstCompiler), Member = "CompileFunctionPointer", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "Unity.Burst.FunctionPointer`1<T>")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600031C")]
		public static void Invoke(float3* destination, Void* src) { }

	}

	[Token(Token = "0x2000101")]
	[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
	public sealed class GetFloat3UInt8_000003BA$PostfixBurstDelegate : MulticastDelegate
	{

		[Address(RVA = "0x53F5F0", Offset = "0x53E7F0", Length = "0xB5")]
		[CallerCount(Count = 13)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000318")]
		public GetFloat3UInt8_000003BA$PostfixBurstDelegate(object unnamed_param_0, IntPtr unnamed_param_1) { }

		[Address(RVA = "0x335340", Offset = "0x334540", Length = "0xF")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000319")]
		public override void Invoke(float3* destination, Void* src) { }

	}

	[Token(Token = "0x200010C")]
	public static class GetFloat3UInt8Normalized_000003BF$BurstDirectCall
	{
		[Token(Token = "0x40003C6")]
		private static IntPtr Pointer; //Field offset: 0x0

		[Address(RVA = "0x108F610", Offset = "0x108E810", Length = "0x17A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(BurstCompiler), Member = "CompileFunctionPointer", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "Unity.Burst.FunctionPointer`1<T>")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6000334")]
		private static IntPtr GetFunctionPointer() { }

		[Address(RVA = "0x108F480", Offset = "0x108E680", Length = "0x184")]
		[BurstDiscard]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(BurstCompiler), Member = "CompileFunctionPointer", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "Unity.Burst.FunctionPointer`1<T>")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6000333")]
		private static void GetFunctionPointerDiscard(ref IntPtr unnamed_param_0) { }

		[Address(RVA = "0x108F790", Offset = "0x108E990", Length = "0x231")]
		[CalledBy(Type = typeof(CachedFunction), Member = "GetFloat3UInt8Normalized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3*), typeof(Void*)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(BurstCompiler), Member = "get_IsEnabled", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(BurstCompiler), Member = "CompileFunctionPointer", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "Unity.Burst.FunctionPointer`1<T>")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000335")]
		public static void Invoke(float3* destination, Void* src) { }

	}

	[Token(Token = "0x200010B")]
	[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
	public sealed class GetFloat3UInt8Normalized_000003BF$PostfixBurstDelegate : MulticastDelegate
	{

		[Address(RVA = "0x53F5F0", Offset = "0x53E7F0", Length = "0xB5")]
		[CallerCount(Count = 13)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000331")]
		public GetFloat3UInt8Normalized_000003BF$PostfixBurstDelegate(object unnamed_param_0, IntPtr unnamed_param_1) { }

		[Address(RVA = "0x335340", Offset = "0x334540", Length = "0xF")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000332")]
		public override void Invoke(float3* destination, Void* src) { }

	}

	[Token(Token = "0x20000F1")]
	[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
	internal sealed class GetIndexDelegate : MulticastDelegate
	{

		[Address(RVA = "0x108FF00", Offset = "0x108F100", Length = "0xB5")]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x60002F1")]
		public GetIndexDelegate(object object, IntPtr method) { }

		[Address(RVA = "0x335340", Offset = "0x334540", Length = "0xF")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002F2")]
		public override int Invoke(Void* baseAddress, int index) { }

	}

	[Token(Token = "0x20000FA")]
	public static class GetIndexValueInt16_000003B6$BurstDirectCall
	{
		[Token(Token = "0x40003BD")]
		private static IntPtr Pointer; //Field offset: 0x0

		[Address(RVA = "0x1090150", Offset = "0x108F350", Length = "0x17A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(BurstCompiler), Member = "CompileFunctionPointer", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "Unity.Burst.FunctionPointer`1<T>")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6000307")]
		private static IntPtr GetFunctionPointer() { }

		[Address(RVA = "0x108FFC0", Offset = "0x108F1C0", Length = "0x184")]
		[BurstDiscard]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(BurstCompiler), Member = "CompileFunctionPointer", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "Unity.Burst.FunctionPointer`1<T>")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6000306")]
		private static void GetFunctionPointerDiscard(ref IntPtr unnamed_param_0) { }

		[Address(RVA = "0x1088F60", Offset = "0x1088160", Length = "0x1E6")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(BurstCompiler), Member = "get_IsEnabled", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(BurstCompiler), Member = "CompileFunctionPointer", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "Unity.Burst.FunctionPointer`1<T>")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000308")]
		public static int Invoke(Void* baseAddress, int index) { }

	}

	[Token(Token = "0x20000F9")]
	[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
	public sealed class GetIndexValueInt16_000003B6$PostfixBurstDelegate : MulticastDelegate
	{

		[Address(RVA = "0x108FF00", Offset = "0x108F100", Length = "0xB5")]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000304")]
		public GetIndexValueInt16_000003B6$PostfixBurstDelegate(object unnamed_param_0, IntPtr unnamed_param_1) { }

		[Address(RVA = "0x335340", Offset = "0x334540", Length = "0xF")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000305")]
		public override int Invoke(Void* baseAddress, int index) { }

	}

	[Token(Token = "0x20000F6")]
	public static class GetIndexValueInt8_000003B4$BurstDirectCall
	{
		[Token(Token = "0x40003BB")]
		private static IntPtr Pointer; //Field offset: 0x0

		[Address(RVA = "0x1090460", Offset = "0x108F660", Length = "0x17A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(BurstCompiler), Member = "CompileFunctionPointer", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "Unity.Burst.FunctionPointer`1<T>")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x60002FD")]
		private static IntPtr GetFunctionPointer() { }

		[Address(RVA = "0x10902D0", Offset = "0x108F4D0", Length = "0x184")]
		[BurstDiscard]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(BurstCompiler), Member = "CompileFunctionPointer", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "Unity.Burst.FunctionPointer`1<T>")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x60002FC")]
		private static void GetFunctionPointerDiscard(ref IntPtr unnamed_param_0) { }

		[Address(RVA = "0x1089160", Offset = "0x1088360", Length = "0x1E7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(BurstCompiler), Member = "get_IsEnabled", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(BurstCompiler), Member = "CompileFunctionPointer", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "Unity.Burst.FunctionPointer`1<T>")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002FE")]
		public static int Invoke(Void* baseAddress, int index) { }

	}

	[Token(Token = "0x20000F5")]
	[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
	public sealed class GetIndexValueInt8_000003B4$PostfixBurstDelegate : MulticastDelegate
	{

		[Address(RVA = "0x108FF00", Offset = "0x108F100", Length = "0xB5")]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x60002FA")]
		public GetIndexValueInt8_000003B4$PostfixBurstDelegate(object unnamed_param_0, IntPtr unnamed_param_1) { }

		[Address(RVA = "0x335340", Offset = "0x334540", Length = "0xF")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002FB")]
		public override int Invoke(Void* baseAddress, int index) { }

	}

	[Token(Token = "0x20000F8")]
	public static class GetIndexValueUInt16_000003B5$BurstDirectCall
	{
		[Token(Token = "0x40003BC")]
		private static IntPtr Pointer; //Field offset: 0x0

		[Address(RVA = "0x1090770", Offset = "0x108F970", Length = "0x17A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(BurstCompiler), Member = "CompileFunctionPointer", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "Unity.Burst.FunctionPointer`1<T>")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6000302")]
		private static IntPtr GetFunctionPointer() { }

		[Address(RVA = "0x10905E0", Offset = "0x108F7E0", Length = "0x184")]
		[BurstDiscard]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(BurstCompiler), Member = "CompileFunctionPointer", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "Unity.Burst.FunctionPointer`1<T>")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6000301")]
		private static void GetFunctionPointerDiscard(ref IntPtr unnamed_param_0) { }

		[Address(RVA = "0x1089350", Offset = "0x1088550", Length = "0x1E6")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(BurstCompiler), Member = "get_IsEnabled", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(BurstCompiler), Member = "CompileFunctionPointer", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "Unity.Burst.FunctionPointer`1<T>")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000303")]
		public static int Invoke(Void* baseAddress, int index) { }

	}

	[Token(Token = "0x20000F7")]
	[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
	public sealed class GetIndexValueUInt16_000003B5$PostfixBurstDelegate : MulticastDelegate
	{

		[Address(RVA = "0x108FF00", Offset = "0x108F100", Length = "0xB5")]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x60002FF")]
		public GetIndexValueUInt16_000003B5$PostfixBurstDelegate(object unnamed_param_0, IntPtr unnamed_param_1) { }

		[Address(RVA = "0x335340", Offset = "0x334540", Length = "0xF")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000300")]
		public override int Invoke(Void* baseAddress, int index) { }

	}

	[Token(Token = "0x20000FC")]
	public static class GetIndexValueUInt32_000003B7$BurstDirectCall
	{
		[Token(Token = "0x40003BE")]
		private static IntPtr Pointer; //Field offset: 0x0

		[Address(RVA = "0x1090A80", Offset = "0x108FC80", Length = "0x17A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(BurstCompiler), Member = "CompileFunctionPointer", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "Unity.Burst.FunctionPointer`1<T>")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x600030C")]
		private static IntPtr GetFunctionPointer() { }

		[Address(RVA = "0x10908F0", Offset = "0x108FAF0", Length = "0x184")]
		[BurstDiscard]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(BurstCompiler), Member = "CompileFunctionPointer", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "Unity.Burst.FunctionPointer`1<T>")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x600030B")]
		private static void GetFunctionPointerDiscard(ref IntPtr unnamed_param_0) { }

		[Address(RVA = "0x1089540", Offset = "0x1088740", Length = "0x1E5")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(BurstCompiler), Member = "get_IsEnabled", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(BurstCompiler), Member = "CompileFunctionPointer", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "Unity.Burst.FunctionPointer`1<T>")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600030D")]
		public static int Invoke(Void* baseAddress, int index) { }

	}

	[Token(Token = "0x20000FB")]
	[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
	public sealed class GetIndexValueUInt32_000003B7$PostfixBurstDelegate : MulticastDelegate
	{

		[Address(RVA = "0x108FF00", Offset = "0x108F100", Length = "0xB5")]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000309")]
		public GetIndexValueUInt32_000003B7$PostfixBurstDelegate(object unnamed_param_0, IntPtr unnamed_param_1) { }

		[Address(RVA = "0x335340", Offset = "0x334540", Length = "0xF")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600030A")]
		public override int Invoke(Void* baseAddress, int index) { }

	}

	[Token(Token = "0x20000F4")]
	public static class GetIndexValueUInt8_000003B3$BurstDirectCall
	{
		[Token(Token = "0x40003BA")]
		private static IntPtr Pointer; //Field offset: 0x0

		[Address(RVA = "0x1090D90", Offset = "0x108FF90", Length = "0x17A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(BurstCompiler), Member = "CompileFunctionPointer", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "Unity.Burst.FunctionPointer`1<T>")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x60002F8")]
		private static IntPtr GetFunctionPointer() { }

		[Address(RVA = "0x1090C00", Offset = "0x108FE00", Length = "0x184")]
		[BurstDiscard]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(BurstCompiler), Member = "CompileFunctionPointer", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "Unity.Burst.FunctionPointer`1<T>")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x60002F7")]
		private static void GetFunctionPointerDiscard(ref IntPtr unnamed_param_0) { }

		[Address(RVA = "0x1089730", Offset = "0x1088930", Length = "0x1E7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(BurstCompiler), Member = "get_IsEnabled", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(BurstCompiler), Member = "CompileFunctionPointer", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "Unity.Burst.FunctionPointer`1<T>")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002F9")]
		public static int Invoke(Void* baseAddress, int index) { }

	}

	[Token(Token = "0x20000F3")]
	[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
	public sealed class GetIndexValueUInt8_000003B3$PostfixBurstDelegate : MulticastDelegate
	{

		[Address(RVA = "0x108FF00", Offset = "0x108F100", Length = "0xB5")]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x60002F5")]
		public GetIndexValueUInt8_000003B3$PostfixBurstDelegate(object unnamed_param_0, IntPtr unnamed_param_1) { }

		[Address(RVA = "0x335340", Offset = "0x334540", Length = "0xF")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002F6")]
		public override int Invoke(Void* baseAddress, int index) { }

	}

	[Token(Token = "0x40003AA")]
	private static FunctionPointer<GetIndexDelegate> s_GetIndexValueInt8Method; //Field offset: 0x0
	[Token(Token = "0x40003AB")]
	private static FunctionPointer<GetIndexDelegate> s_GetIndexValueUInt8Method; //Field offset: 0x8
	[Token(Token = "0x40003AC")]
	private static FunctionPointer<GetIndexDelegate> s_GetIndexValueInt16Method; //Field offset: 0x10
	[Token(Token = "0x40003AD")]
	private static FunctionPointer<GetIndexDelegate> s_GetIndexValueUInt16Method; //Field offset: 0x18
	[Token(Token = "0x40003AE")]
	private static FunctionPointer<GetIndexDelegate> s_GetIndexValueUInt32Method; //Field offset: 0x20
	[Token(Token = "0x40003AF")]
	private static FunctionPointer<GetFloat3Delegate> s_GetFloat3FloatMethod; //Field offset: 0x28
	[Token(Token = "0x40003B0")]
	private static FunctionPointer<GetFloat3Delegate> s_GetFloat3Int8Method; //Field offset: 0x30
	[Token(Token = "0x40003B1")]
	private static FunctionPointer<GetFloat3Delegate> s_GetFloat3UInt8Method; //Field offset: 0x38
	[Token(Token = "0x40003B2")]
	private static FunctionPointer<GetFloat3Delegate> s_GetFloat3Int16Method; //Field offset: 0x40
	[Token(Token = "0x40003B3")]
	private static FunctionPointer<GetFloat3Delegate> s_GetFloat3UInt16Method; //Field offset: 0x48
	[Token(Token = "0x40003B4")]
	private static FunctionPointer<GetFloat3Delegate> s_GetFloat3UInt32Method; //Field offset: 0x50
	[Token(Token = "0x40003B5")]
	private static FunctionPointer<GetFloat3Delegate> s_GetFloat3Int8NormalizedMethod; //Field offset: 0x58
	[Token(Token = "0x40003B6")]
	private static FunctionPointer<GetFloat3Delegate> s_GetFloat3UInt8NormalizedMethod; //Field offset: 0x60
	[Token(Token = "0x40003B7")]
	private static FunctionPointer<GetFloat3Delegate> s_GetFloat3Int16NormalizedMethod; //Field offset: 0x68
	[Token(Token = "0x40003B8")]
	private static FunctionPointer<GetFloat3Delegate> s_GetFloat3UInt16NormalizedMethod; //Field offset: 0x70
	[Token(Token = "0x40003B9")]
	private static FunctionPointer<GetFloat3Delegate> s_GetFloat3UInt32NormalizedMethod; //Field offset: 0x78

	[Address(RVA = "0x10883D0", Offset = "0x10875D0", Length = "0x8")]
	[BurstCompile]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GetFloat3Float_000003B8$BurstDirectCall), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3*), typeof(Void*)}, ReturnType = typeof(void))]
	[MonoPInvokeCallback(typeof(GetFloat3Delegate))]
	[Token(Token = "0x60002D6")]
	private static void GetFloat3Float(float3* destination, Void* src) { }

	[Address(RVA = "0x10883A0", Offset = "0x10875A0", Length = "0x2E")]
	[BurstCompile]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[MonoPInvokeCallback(typeof(GetFloat3Delegate))]
	[Token(Token = "0x60002E6")]
	internal static void GetFloat3Float$BurstManaged(float3* destination, Void* src) { }

	[Address(RVA = "0x1088630", Offset = "0x1087830", Length = "0x8")]
	[BurstCompile]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GetFloat3Int16_000003BB$BurstDirectCall), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3*), typeof(Void*)}, ReturnType = typeof(void))]
	[MonoPInvokeCallback(typeof(GetFloat3Delegate))]
	[Token(Token = "0x60002D9")]
	private static void GetFloat3Int16(float3* destination, Void* src) { }

	[Address(RVA = "0x10885E0", Offset = "0x10877E0", Length = "0x43")]
	[BurstCompile]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[MonoPInvokeCallback(typeof(GetFloat3Delegate))]
	[Token(Token = "0x60002E9")]
	internal static void GetFloat3Int16$BurstManaged(float3* destination, Void* src) { }

	[Address(RVA = "0x10883E0", Offset = "0x10875E0", Length = "0x1F0")]
	[BurstCompile]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
	[Calls(Type = typeof(CachedFunction), Member = "GetFloat3Int16Normalized$BurstManaged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3*), typeof(Void*)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BurstCompiler), Member = "CompileFunctionPointer", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "Unity.Burst.FunctionPointer`1<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(BurstCompiler), Member = "get_IsEnabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[MonoPInvokeCallback(typeof(GetFloat3Delegate))]
	[Token(Token = "0x60002DE")]
	private static void GetFloat3Int16Normalized(float3* destination, Void* src) { }

	[Address(RVA = "0x1087CB0", Offset = "0x1086EB0", Length = "0xA9")]
	[BurstCompile]
	[CalledBy(Type = typeof(GetFloat3Int16Normalized_000003C0$BurstDirectCall), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3*), typeof(Void*)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CachedFunction), Member = "GetFloat3Int16Normalized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3*), typeof(Void*)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[MonoPInvokeCallback(typeof(GetFloat3Delegate))]
	[Token(Token = "0x60002EE")]
	internal static void GetFloat3Int16Normalized$BurstManaged(float3* destination, Void* src) { }

	[Address(RVA = "0x1088890", Offset = "0x1087A90", Length = "0x8")]
	[BurstCompile]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GetFloat3Int8_000003B9$BurstDirectCall), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3*), typeof(Void*)}, ReturnType = typeof(void))]
	[MonoPInvokeCallback(typeof(GetFloat3Delegate))]
	[Token(Token = "0x60002D7")]
	private static void GetFloat3Int8(float3* destination, Void* src) { }

	[Address(RVA = "0x1088840", Offset = "0x1087A40", Length = "0x43")]
	[BurstCompile]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[MonoPInvokeCallback(typeof(GetFloat3Delegate))]
	[Token(Token = "0x60002E7")]
	internal static void GetFloat3Int8$BurstManaged(float3* destination, Void* src) { }

	[Address(RVA = "0x1088640", Offset = "0x1087840", Length = "0x1F0")]
	[BurstCompile]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
	[Calls(Type = typeof(CachedFunction), Member = "GetFloat3Int8Normalized$BurstManaged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3*), typeof(Void*)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BurstCompiler), Member = "CompileFunctionPointer", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "Unity.Burst.FunctionPointer`1<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(BurstCompiler), Member = "get_IsEnabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[MonoPInvokeCallback(typeof(GetFloat3Delegate))]
	[Token(Token = "0x60002DC")]
	private static void GetFloat3Int8Normalized(float3* destination, Void* src) { }

	[Address(RVA = "0x1087D60", Offset = "0x1086F60", Length = "0xA9")]
	[BurstCompile]
	[CalledBy(Type = typeof(GetFloat3Int8Normalized_000003BE$BurstDirectCall), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3*), typeof(Void*)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CachedFunction), Member = "GetFloat3Int8Normalized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3*), typeof(Void*)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[MonoPInvokeCallback(typeof(GetFloat3Delegate))]
	[Token(Token = "0x60002EC")]
	internal static void GetFloat3Int8Normalized$BurstManaged(float3* destination, Void* src) { }

	[Address(RVA = "0x1088960", Offset = "0x1087B60", Length = "0x8")]
	[BurstCompile]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GetFloat3UInt16_000003BC$BurstDirectCall), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3*), typeof(Void*)}, ReturnType = typeof(void))]
	[MonoPInvokeCallback(typeof(GetFloat3Delegate))]
	[Token(Token = "0x60002DA")]
	private static void GetFloat3UInt16(float3* destination, Void* src) { }

	[Address(RVA = "0x1088910", Offset = "0x1087B10", Length = "0x43")]
	[BurstCompile]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[MonoPInvokeCallback(typeof(GetFloat3Delegate))]
	[Token(Token = "0x60002EA")]
	internal static void GetFloat3UInt16$BurstManaged(float3* destination, Void* src) { }

	[Address(RVA = "0x1088900", Offset = "0x1087B00", Length = "0x8")]
	[BurstCompile]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GetFloat3UInt16Normalized_000003C1$BurstDirectCall), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3*), typeof(Void*)}, ReturnType = typeof(void))]
	[MonoPInvokeCallback(typeof(GetFloat3Delegate))]
	[Token(Token = "0x60002DF")]
	private static void GetFloat3UInt16Normalized(float3* destination, Void* src) { }

	[Address(RVA = "0x10888A0", Offset = "0x1087AA0", Length = "0x57")]
	[BurstCompile]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[MonoPInvokeCallback(typeof(GetFloat3Delegate))]
	[Token(Token = "0x60002EF")]
	internal static void GetFloat3UInt16Normalized$BurstManaged(float3* destination, Void* src) { }

	[Address(RVA = "0x1088A40", Offset = "0x1087C40", Length = "0x8")]
	[BurstCompile]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GetFloat3UInt32_000003BD$BurstDirectCall), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3*), typeof(Void*)}, ReturnType = typeof(void))]
	[MonoPInvokeCallback(typeof(GetFloat3Delegate))]
	[Token(Token = "0x60002DB")]
	private static void GetFloat3UInt32(float3* destination, Void* src) { }

	[Address(RVA = "0x10889F0", Offset = "0x1087BF0", Length = "0x4C")]
	[BurstCompile]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[MonoPInvokeCallback(typeof(GetFloat3Delegate))]
	[Token(Token = "0x60002EB")]
	internal static void GetFloat3UInt32$BurstManaged(float3* destination, Void* src) { }

	[Address(RVA = "0x10889E0", Offset = "0x1087BE0", Length = "0x8")]
	[BurstCompile]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GetFloat3UInt32Normalized_000003C2$BurstDirectCall), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3*), typeof(Void*)}, ReturnType = typeof(void))]
	[MonoPInvokeCallback(typeof(GetFloat3Delegate))]
	[Token(Token = "0x60002E0")]
	private static void GetFloat3UInt32Normalized(float3* destination, Void* src) { }

	[Address(RVA = "0x1088970", Offset = "0x1087B70", Length = "0x60")]
	[BurstCompile]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[MonoPInvokeCallback(typeof(GetFloat3Delegate))]
	[Token(Token = "0x60002F0")]
	internal static void GetFloat3UInt32Normalized$BurstManaged(float3* destination, Void* src) { }

	[Address(RVA = "0x1088B10", Offset = "0x1087D10", Length = "0x8")]
	[BurstCompile]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GetFloat3UInt8_000003BA$BurstDirectCall), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3*), typeof(Void*)}, ReturnType = typeof(void))]
	[MonoPInvokeCallback(typeof(GetFloat3Delegate))]
	[Token(Token = "0x60002D8")]
	private static void GetFloat3UInt8(float3* destination, Void* src) { }

	[Address(RVA = "0x1088AC0", Offset = "0x1087CC0", Length = "0x43")]
	[BurstCompile]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[MonoPInvokeCallback(typeof(GetFloat3Delegate))]
	[Token(Token = "0x60002E8")]
	internal static void GetFloat3UInt8$BurstManaged(float3* destination, Void* src) { }

	[Address(RVA = "0x1088AB0", Offset = "0x1087CB0", Length = "0x8")]
	[BurstCompile]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GetFloat3UInt8Normalized_000003BF$BurstDirectCall), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3*), typeof(Void*)}, ReturnType = typeof(void))]
	[MonoPInvokeCallback(typeof(GetFloat3Delegate))]
	[Token(Token = "0x60002DD")]
	private static void GetFloat3UInt8Normalized(float3* destination, Void* src) { }

	[Address(RVA = "0x1088A50", Offset = "0x1087C50", Length = "0x57")]
	[BurstCompile]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[MonoPInvokeCallback(typeof(GetFloat3Delegate))]
	[Token(Token = "0x60002ED")]
	internal static void GetFloat3UInt8Normalized$BurstManaged(float3* destination, Void* src) { }

	[Address(RVA = "0x1088B20", Offset = "0x1087D20", Length = "0x414")]
	[CalledBy(Type = typeof(VertexBufferConfigBase), Member = "GetVector3SparseJob", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(int), typeof(GltfComponentType), typeof(GltfComponentType), typeof(float3*), typeof(int), typeof(Nullable`1<JobHandle>&), typeof(bool)}, ReturnType = typeof(System.Nullable`1<Unity.Jobs.JobHandle>))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BurstCompiler), Member = "CompileFunctionPointer", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "Unity.Burst.FunctionPointer`1<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60002CF")]
	public static FunctionPointer<GetIndexDelegate> GetIndexConverter(GltfComponentType format) { }

	[Address(RVA = "0x1088F60", Offset = "0x1088160", Length = "0x1E6")]
	[BurstCompile]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BurstCompiler), Member = "get_IsEnabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
	[Calls(Type = typeof(BurstCompiler), Member = "CompileFunctionPointer", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "Unity.Burst.FunctionPointer`1<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[MonoPInvokeCallback(typeof(GetIndexDelegate))]
	[Token(Token = "0x60002D4")]
	private static int GetIndexValueInt16(Void* baseAddress, int index) { }

	[Address(RVA = "0x1088F50", Offset = "0x1088150", Length = "0x8")]
	[BurstCompile]
	[CallerCount(Count = 0)]
	[MonoPInvokeCallback(typeof(GetIndexDelegate))]
	[Token(Token = "0x60002E4")]
	internal static int GetIndexValueInt16$BurstManaged(Void* baseAddress, int index) { }

	[Address(RVA = "0x1089160", Offset = "0x1088360", Length = "0x1E7")]
	[BurstCompile]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BurstCompiler), Member = "get_IsEnabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
	[Calls(Type = typeof(BurstCompiler), Member = "CompileFunctionPointer", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "Unity.Burst.FunctionPointer`1<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[MonoPInvokeCallback(typeof(GetIndexDelegate))]
	[Token(Token = "0x60002D2")]
	private static int GetIndexValueInt8(Void* baseAddress, int index) { }

	[Address(RVA = "0x1089150", Offset = "0x1088350", Length = "0x8")]
	[BurstCompile]
	[CallerCount(Count = 0)]
	[MonoPInvokeCallback(typeof(GetIndexDelegate))]
	[Token(Token = "0x60002E2")]
	internal static int GetIndexValueInt8$BurstManaged(Void* baseAddress, int index) { }

	[Address(RVA = "0x1089350", Offset = "0x1088550", Length = "0x1E6")]
	[BurstCompile]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BurstCompiler), Member = "get_IsEnabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
	[Calls(Type = typeof(BurstCompiler), Member = "CompileFunctionPointer", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "Unity.Burst.FunctionPointer`1<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[MonoPInvokeCallback(typeof(GetIndexDelegate))]
	[Token(Token = "0x60002D3")]
	private static int GetIndexValueUInt16(Void* baseAddress, int index) { }

	[Address(RVA = "0x7C7F20", Offset = "0x7C7120", Length = "0x8")]
	[BurstCompile]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[MonoPInvokeCallback(typeof(GetIndexDelegate))]
	[Token(Token = "0x60002E3")]
	internal static int GetIndexValueUInt16$BurstManaged(Void* baseAddress, int index) { }

	[Address(RVA = "0x1089540", Offset = "0x1088740", Length = "0x1E5")]
	[BurstCompile]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BurstCompiler), Member = "get_IsEnabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
	[Calls(Type = typeof(BurstCompiler), Member = "CompileFunctionPointer", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "Unity.Burst.FunctionPointer`1<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[MonoPInvokeCallback(typeof(GetIndexDelegate))]
	[Token(Token = "0x60002D5")]
	private static int GetIndexValueUInt32(Void* baseAddress, int index) { }

	[Address(RVA = "0x7C7E60", Offset = "0x7C7060", Length = "0x7")]
	[BurstCompile]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[MonoPInvokeCallback(typeof(GetIndexDelegate))]
	[Token(Token = "0x60002E5")]
	internal static int GetIndexValueUInt32$BurstManaged(Void* baseAddress, int index) { }

	[Address(RVA = "0x1089730", Offset = "0x1088930", Length = "0x1E7")]
	[BurstCompile]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BurstCompiler), Member = "get_IsEnabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
	[Calls(Type = typeof(BurstCompiler), Member = "CompileFunctionPointer", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "Unity.Burst.FunctionPointer`1<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[MonoPInvokeCallback(typeof(GetIndexDelegate))]
	[Token(Token = "0x60002D1")]
	private static int GetIndexValueUInt8(Void* baseAddress, int index) { }

	[Address(RVA = "0x7C7D40", Offset = "0x7C6F40", Length = "0x8")]
	[BurstCompile]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[MonoPInvokeCallback(typeof(GetIndexDelegate))]
	[Token(Token = "0x60002E1")]
	internal static int GetIndexValueUInt8$BurstManaged(Void* baseAddress, int index) { }

	[Address(RVA = "0x1089920", Offset = "0x1088B20", Length = "0x838")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BurstCompiler), Member = "CompileFunctionPointer", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "Unity.Burst.FunctionPointer`1<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 22)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60002D0")]
	public static FunctionPointer<GetFloat3Delegate> GetPositionConverter(GltfComponentType format, bool normalized) { }

}

