namespace Unity.Collections.LowLevel.Unsafe;

[NativeHeader("Runtime/Export/BurstLike/BurstLike.bindings.h")]
[StaticAccessor("BurstLike", StaticAccessorType::DoubleColon (2))]
[Token(Token = "0x2000049")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.ParticleSystemModule"})]
internal static class BurstLike
{
	[Token(Token = "0x200004B")]
	public static class SharedStatic
	{

		[Address(RVA = "0x193EDE0", Offset = "0x193DFE0", Length = "0x75")]
		[CalledBy(Type = typeof(SharedStatic`1), Member = "GetOrCreate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TContext"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = "Unity.Collections.LowLevel.Unsafe.BurstLike+SharedStatic`1<T>")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60000C5")]
		public static Void* GetOrCreateSharedStaticInternal(long getHashCode64, long getSubHashCode64, uint sizeOf, uint alignment) { }

	}

	[IsReadOnly]
	[Token(Token = "0x200004A")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.ParticleSystemModule"})]
	public struct SharedStatic
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000BB")]
		private readonly Void* _buffer; //Field offset: 0x0

		[Token(Token = "0x1700001D")]
		public T Data
		{
			[Address(RVA = "0xF15310", Offset = "0xF14510", Length = "0x24")]
			[CallerCount(Count = 14)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
			[DeduplicatedMethod]
			[Token(Token = "0x60000C3")]
			 get { } //Length: 36
		}

		[Address(RVA = "0xC498F0", Offset = "0xC48AF0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000C2")]
		private SharedStatic`1(Void* buffer) { }

		[Address(RVA = "0xF15310", Offset = "0xF14510", Length = "0x24")]
		[CallerCount(Count = 14)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[DeduplicatedMethod]
		[Token(Token = "0x60000C3")]
		public T get_Data() { }

		[Address(RVA = "0x605EF0", Offset = "0x6050F0", Length = "0x88")]
		[CalledBy(Type = typeof(JobStruct`1), Member = ".cctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ParallelForJobStruct`1), Member = ".cctor", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(SharedStatic), Member = "GetOrCreateSharedStaticInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(long), typeof(uint), typeof(uint)}, ReturnType = typeof(Void*))]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000C4")]
		public static SharedStatic<T> GetOrCreate(uint alignment = 0) { }

	}


}

