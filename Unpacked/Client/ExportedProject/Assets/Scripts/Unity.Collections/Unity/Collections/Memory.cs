namespace Unity.Collections;

[GenerateTestsForBurstCompatibility]
[Token(Token = "0x200001F")]
internal struct Memory
{
	[GenerateTestsForBurstCompatibility]
	[Token(Token = "0x2000020")]
	public struct Unmanaged
	{
		[GenerateTestsForBurstCompatibility]
		[Token(Token = "0x2000021")]
		public struct Array
		{

			[Address(RVA = "0x1820000", Offset = "0x181F200", Length = "0x116")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
			[Calls(Type = typeof(AllocatorManager), Member = "Try", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Block&)}, ReturnType = typeof(int))]
			[CallsDeduplicatedMethods(Count = 2)]
			[ContainsUnimplementedInstructions]
			[Token(Token = "0x6000049")]
			private static Void* CustomResize(Void* oldPointer, long oldCount, long newCount, AllocatorHandle allocator, long size, int align) { }

			[Address(RVA = "0x1820120", Offset = "0x181F320", Length = "0x8")]
			[CallerCount(Count = 0)]
			[ContainsUnimplementedInstructions]
			[Token(Token = "0x6000048")]
			private static bool IsCustom(AllocatorHandle allocator) { }

			[Address(RVA = "0x1820130", Offset = "0x181F330", Length = "0x1B1")]
			[CalledBy(Type = typeof(NativeReferenceDispose), Member = "Dispose", ReturnType = typeof(void))]
			[CalledBy(Type = typeof(UnsafeStreamBlockData), Member = "Free", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeStreamBlock*)}, ReturnType = typeof(void))]
			[CalledBy(Type = typeof(NativeReferenceDisposeJob), Member = "Execute", ReturnType = typeof(void))]
			[CalledBy(Type = typeof(Unmanaged), Member = "Free", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
			[CalledBy(Type = typeof(Unmanaged), Member = "Allocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(int), typeof(AllocatorHandle)}, ReturnType = typeof(Void*))]
			[CalledBy(Type = typeof(Unmanaged), Member = "Free", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T*", typeof(AllocatorHandle)}, ReturnType = typeof(void))]
			[CalledBy(Type = typeof(AllocatorManager), Member = "Try", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Block&)}, ReturnType = typeof(int))]
			[CalledBy(Type = typeof(AllocatorManager), Member = "TryLegacy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Block&)}, ReturnType = typeof(int))]
			[CalledBy(Type = typeof(Array), Member = "Resize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T*", typeof(long), typeof(long), typeof(AllocatorHandle)}, ReturnType = "T*")]
			[CallerCount(Count = 11)]
			[Calls(Type = typeof(UnsafeUtility), Member = "FreeTracked", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Allocator)}, ReturnType = typeof(void))]
			[Calls(Type = typeof(AllocatorManager), Member = "Try", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Block&)}, ReturnType = typeof(int))]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
			[Calls(Type = typeof(UnsafeUtility), Member = "MallocTracked", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(int), typeof(Allocator), typeof(int)}, ReturnType = typeof(Void*))]
			[Calls(Type = typeof(UnsafeUtility), Member = "MemCpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[CallsDeduplicatedMethods(Count = 2)]
			[ContainsUnimplementedInstructions]
			[Token(Token = "0x600004A")]
			internal static Void* Resize(Void* oldPointer, long oldCount, long newCount, AllocatorHandle allocator, long size, int align) { }

			[Address(RVA = "0x7CD570", Offset = "0x7CC770", Length = "0x89")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
			[Calls(Type = typeof(UnsafeUtility), Member = "AlignOf", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(int))]
			[Calls(Type = typeof(Array), Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(long), typeof(long), typeof(AllocatorHandle), typeof(long), typeof(int)}, ReturnType = typeof(Void*))]
			[DeduplicatedMethod]
			[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
			[Token(Token = "0x600004B")]
			internal static T* Resize(T* oldPointer, long oldCount, long newCount, AllocatorHandle allocator) { }

		}


		[Address(RVA = "0x1820F50", Offset = "0x1820150", Length = "0x2D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Array), Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(long), typeof(long), typeof(AllocatorHandle), typeof(long), typeof(int)}, ReturnType = typeof(Void*))]
		[Token(Token = "0x6000045")]
		internal static Void* Allocate(long size, int align, AllocatorHandle allocator) { }

		[Address(RVA = "0x1820F80", Offset = "0x1820180", Length = "0x38")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Array), Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(long), typeof(long), typeof(AllocatorHandle), typeof(long), typeof(int)}, ReturnType = typeof(Void*))]
		[Token(Token = "0x6000046")]
		internal static void Free(Void* pointer, AllocatorHandle allocator) { }

		[Address(RVA = "0x7D02A0", Offset = "0x7CF4A0", Length = "0x88")]
		[CalledBy(Type = typeof(UnsafeQueueDispose), Member = "Dispose", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(NativeBitArrayDispose), Member = "Dispose", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(NativeTextDispose), Member = "Dispose", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UnsafeQueueData), Member = "DeallocateQueue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeQueueData*), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UnsafeQueue`1), Member = "Free", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.UnsafeQueue`1<T>*"}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UnsafeText), Member = "Free", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeText*)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UnsafeBitArray), Member = "Free", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeBitArray*), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(HashMapHelper`1), Member = "Free", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.LowLevel.Unsafe.HashMapHelper`1<TKey>*"}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UnsafeRingQueue`1), Member = "Free", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.LowLevel.Unsafe.UnsafeRingQueue`1<T>*"}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
		[Calls(Type = typeof(Array), Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(long), typeof(long), typeof(AllocatorHandle), typeof(long), typeof(int)}, ReturnType = typeof(Void*))]
		[Calls(Type = typeof(UnsafeUtility), Member = "AlignOf", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(int))]
		[DeduplicatedMethod]
		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
		[Token(Token = "0x6000047")]
		internal static void Free(T* pointer, AllocatorHandle allocator) { }

	}


}

