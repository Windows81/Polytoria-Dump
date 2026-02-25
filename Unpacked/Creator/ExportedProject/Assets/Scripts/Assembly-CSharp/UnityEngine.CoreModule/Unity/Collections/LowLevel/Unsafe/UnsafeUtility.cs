namespace Unity.Collections.LowLevel.Unsafe;

[NativeHeader("Runtime/Export/Unsafe/UnsafeUtility.bindings.h")]
[StaticAccessor("UnsafeUtility", StaticAccessorType::DoubleColon (2))]
[Token(Token = "0x200005C")]
public static class UnsafeUtility
{
	[Token(Token = "0x200005D")]
	private struct AlignOfHelper
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000BD")]
		public byte dummy; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000BE")]
		public T data; //Field offset: 0x0

	}


	[Address(RVA = "0x30E8E0", Offset = "0x30DAE0", Length = "0x4")]
	[CallerCount(Count = 2057)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000EA")]
	public static Void* AddressOf(ref T output) { }

	[Address(RVA = "0x7C7700", Offset = "0x7C6900", Length = "0x1A")]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.TempMeshAllocatorImpl", Member = "Allocate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = "Unity.Collections.NativeSlice`1<T>")]
	[CalledBy(Type = "UnityEngine.UIElements.Layout.LayoutDataStore+ComponentDataStore", Member = "ResizeCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.Layout.LayoutDataStore", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.Layout.ComponentType[]", typeof(int), typeof(Allocator)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NativeArray`1), Member = "Allocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Allocator), "Unity.Collections.NativeArray`1<T>&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.Collections.AllocatorManager", Member = "Free", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.AllocatorManager+AllocatorHandle", "T*", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.Collections.Memory+Unmanaged+Array", Member = "Resize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T*", typeof(long), typeof(long), "Unity.Collections.AllocatorManager+AllocatorHandle"}, ReturnType = "T*")]
	[CalledBy(Type = "Unity.Collections.Memory+Unmanaged", Member = "Free", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T*", "Unity.Collections.AllocatorManager+AllocatorHandle"}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[DeduplicatedMethod]
	[Token(Token = "0x60000E5")]
	public static int AlignOf() { }

	[Address(RVA = "0x7C7800", Offset = "0x7C6A00", Length = "0xF")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000EF")]
	public static T ArrayElementAsRef(Void* ptr, int index) { }

	[Address(RVA = "0x30E8E0", Offset = "0x30DAE0", Length = "0x4")]
	[CallerCount(Count = 2057)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000ED")]
	internal static T As(object from) { }

	[Address(RVA = "0x30E8E0", Offset = "0x30DAE0", Length = "0x4")]
	[CallerCount(Count = 2057)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000EC")]
	public static T As(ref U from) { }

	[Address(RVA = "0x30E8E0", Offset = "0x30DAE0", Length = "0x4")]
	[CallerCount(Count = 2057)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000EE")]
	public static T AsRef(Void* ptr) { }

	[Address(RVA = "0x7C7930", Offset = "0x7C6B30", Length = "0x6")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x60000F2")]
	public static bool EnumEquals(T lhs, T rhs) { }

	[Address(RVA = "0x7C7990", Offset = "0x7C6B90", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[DeduplicatedMethod]
	[Token(Token = "0x60000F0")]
	public static int EnumToInt(T enumValue) { }

	[Address(RVA = "0x1941AC0", Offset = "0x1940CC0", Length = "0x40")]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.TempMeshAllocatorImpl", Member = "Clear", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.Layout.LayoutDataStore+ComponentDataStore", Member = "Dispose", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.Layout.LayoutDataStore+ComponentDataStore", Member = "ResizeCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.Layout.LayoutDataStore", Member = "Dispose", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.Layout.LayoutDataStore", Member = "ResizeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Void*", typeof(long), typeof(long), typeof(long), typeof(int), typeof(Allocator)}, ReturnType = "System.Void*")]
	[CalledBy(Type = "UnityEngine.UIElements.Layout.LayoutList`1", Member = "Dispose", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.Layout.LayoutList`1", Member = "ResizeCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.Layout.LayoutList`1", Member = "ResizeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Void*", typeof(long), typeof(long), typeof(long), typeof(int), typeof(Allocator)}, ReturnType = "System.Void*")]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[ThreadSafe(ThrowsException = True)]
	[Token(Token = "0x60000DA")]
	public static void Free(Void* memory, Allocator allocator) { }

	[Address(RVA = "0x1941A80", Offset = "0x1940C80", Length = "0x40")]
	[CalledBy(Type = typeof(NativeArray`1), Member = "Dispose", ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.Collections.Memory+Unmanaged+Array", Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Void*", typeof(long), typeof(long), "Unity.Collections.AllocatorManager+AllocatorHandle", typeof(long), typeof(int)}, ReturnType = "System.Void*")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[ThreadSafe(ThrowsException = True)]
	[Token(Token = "0x60000D8")]
	public static void FreeTracked(Void* memory, Allocator allocator) { }

	[Address(RVA = "0x1941B00", Offset = "0x1940D00", Length = "0x65")]
	[CalledBy(Type = typeof(Mesh), Member = "SetIndexBufferData", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int), typeof(int), typeof(int), typeof(MeshUpdateFlags)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[ContainsInvalidInstructions]
	[Token(Token = "0x60000E4")]
	internal static string GetReasonForArrayNonBlittable(Array arr) { }

	[Address(RVA = "0x1941B70", Offset = "0x1940D70", Length = "0x207")]
	[CalledBy(Type = typeof(UnsafeUtility), Member = "GetReasonForTypeNonBlittableImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Type), Member = "get_IsValueType", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "get_IsPrimitive", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(UnsafeUtility), Member = "GetReasonForTypeNonBlittableImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 5)]
	[Token(Token = "0x60000E2")]
	private static string GetReasonForTypeNonBlittableImpl(Type t, string name) { }

	[Address(RVA = "0x7C79B0", Offset = "0x7C6BB0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000F1")]
	private static void InternalEnumToInt(ref T enumValue, ref int intValue) { }

	[Address(RVA = "0x1941D80", Offset = "0x1940F80", Length = "0x88")]
	[CalledBy(Type = typeof(Mesh), Member = "SetIndexBufferData", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int), typeof(int), typeof(int), typeof(MeshUpdateFlags)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "get_IsValueType", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60000E3")]
	internal static bool IsArrayBlittable(Array arr) { }

	[Address(RVA = "0x1941E70", Offset = "0x1941070", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[ThreadSafe]
	[Token(Token = "0x60000E0")]
	public static bool IsBlittable(Type type) { }

	[Address(RVA = "0x1941E10", Offset = "0x1941010", Length = "0x5D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "get_IsValueType", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60000E1")]
	private static bool IsBlittableValueType(Type t) { }

	[Address(RVA = "0x1941F10", Offset = "0x1941110", Length = "0x50")]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.TempMeshAllocatorImpl", Member = "Allocate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = "Unity.Collections.NativeSlice`1<T>")]
	[CalledBy(Type = "UnityEngine.UIElements.Layout.LayoutDataStore+ComponentDataStore", Member = "ResizeCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.Layout.LayoutDataStore", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.Layout.ComponentType[]", typeof(int), typeof(Allocator)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.Layout.LayoutDataStore", Member = "ResizeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Void*", typeof(long), typeof(long), typeof(long), typeof(int), typeof(Allocator)}, ReturnType = "System.Void*")]
	[CalledBy(Type = "UnityEngine.UIElements.Layout.LayoutList`1", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Allocator)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.Layout.LayoutList`1", Member = "ResizeCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.Layout.LayoutList`1", Member = "ResizeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Void*", typeof(long), typeof(long), typeof(long), typeof(int), typeof(Allocator)}, ReturnType = "System.Void*")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[ThreadSafe(ThrowsException = True)]
	[Token(Token = "0x60000D9")]
	public static Void* Malloc(long size, int alignment, Allocator allocator) { }

	[Address(RVA = "0x1941EB0", Offset = "0x19410B0", Length = "0x60")]
	[CalledBy(Type = typeof(NativeArray`1), Member = "Allocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Allocator), "Unity.Collections.NativeArray`1<T>&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.Collections.Memory+Unmanaged+Array", Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Void*", typeof(long), typeof(long), "Unity.Collections.AllocatorManager+AllocatorHandle", typeof(long), typeof(int)}, ReturnType = "System.Void*")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[ThreadSafe(ThrowsException = True)]
	[Token(Token = "0x60000D7")]
	public static Void* MallocTracked(long size, int alignment, Allocator allocator, int callstacksToSkip) { }

	[Address(RVA = "0x1941F60", Offset = "0x1941160", Length = "0x44")]
	[CalledBy(Type = "UnityEngine.UIElements.Layout.LayoutDataStore", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.Layout.ComponentType[]", typeof(int), typeof(Allocator)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.Layout.LayoutList`1", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Allocator)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NativeArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Allocator), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.Collections.LowLevel.Unsafe.UnsafeStream", Member = "AllocateForEach", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000DF")]
	public static void MemClear(Void* destination, long size) { }

	[Address(RVA = "0x1942010", Offset = "0x1941210", Length = "0x52")]
	[CallerCount(Count = 20)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[ThreadSafe(ThrowsException = True)]
	[Token(Token = "0x60000DB")]
	public static void MemCpy(Void* destination, Void* source, long size) { }

	[Address(RVA = "0x1941FB0", Offset = "0x19411B0", Length = "0x60")]
	[CalledBy(Type = typeof(NativeSlice`1), Member = "CopyFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeSlice`1<T>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[ThreadSafe(ThrowsException = True)]
	[Token(Token = "0x60000DC")]
	public static void MemCpyStride(Void* destination, int destinationStride, Void* source, int sourceStride, int elementSize, int count) { }

	[Address(RVA = "0x1942070", Offset = "0x1941270", Length = "0x52")]
	[CalledBy(Type = "UnityEngine.UIElements.Layout.LayoutList`1", Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "T"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.Layout.LayoutList`1", Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[ThreadSafe(ThrowsException = True)]
	[Token(Token = "0x60000DD")]
	public static void MemMove(Void* destination, Void* source, long size) { }

	[Address(RVA = "0x19420D0", Offset = "0x19412D0", Length = "0x53")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[ThreadSafe(ThrowsException = True)]
	[Token(Token = "0x60000DE")]
	public static void MemSet(Void* destination, byte value, long size) { }

	[Address(RVA = "0x7C7CF0", Offset = "0x7C6EF0", Length = "0x49")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000E6")]
	public static T ReadArrayElement(Void* source, int index) { }

	[Address(RVA = "0x7C79F0", Offset = "0x7C6BF0", Length = "0xF")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000E7")]
	public static T ReadArrayElementWithStride(Void* source, int index, int stride) { }

	[Address(RVA = "0x7C81A0", Offset = "0x7C73A0", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000EB")]
	public static int SizeOf() { }

	[Address(RVA = "0x7C8650", Offset = "0x7C7850", Length = "0x46")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000E8")]
	public static void WriteArrayElement(Void* destination, int index, T value) { }

	[Address(RVA = "0x7C8310", Offset = "0x7C7510", Length = "0xF")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000E9")]
	public static void WriteArrayElementWithStride(Void* destination, int index, int stride, T value) { }

}

