namespace Unity.Collections;

[Extension]
[Token(Token = "0x200000B")]
public static class AllocatorManager
{
	[Token(Token = "0x200000D")]
	internal struct AllocatorHandle : IAllocator, IDisposable, IEquatable<AllocatorHandle>, IComparable<AllocatorHandle>
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400000D")]
		public ushort Index; //Field offset: 0x0
		[FieldOffset(Offset = "0x2")]
		[Token(Token = "0x400000E")]
		public ushort Version; //Field offset: 0x2

		[Token(Token = "0x17000003")]
		public override AllocatorHandle Handle
		{
			[Address(RVA = "0x344910", Offset = "0x343B10", Length = "0x3")]
			[CallerCount(Count = 129)]
			[DeduplicatedMethod]
			[Token(Token = "0x6000028")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000001")]
		internal TableEntry TableEntry
		{
			[Address(RVA = "0x181F650", Offset = "0x181E850", Length = "0x83")]
			[CalledBy(Type = typeof(AllocatorHandle), Member = "Dispose", ReturnType = typeof(void))]
			[CalledBy(Type = typeof(AllocatorManager), Member = "allocate_block", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Block&)}, ReturnType = typeof(int))]
			[CalledBy(Type = typeof(AllocatorManager), Member = "forward_mono_allocate_block", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Block&), typeof(Int32&)}, ReturnType = typeof(void))]
			[CalledBy(Type = typeof(AllocatorManager), Member = "Try", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Block&)}, ReturnType = typeof(int))]
			[CallerCount(Count = 5)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
			[Calls(Type = typeof(Unity.Collections.AllocatorManager+Array32768`1<Unity.Collections.AllocatorManager+TableEntry>), Member = "ElementAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(TableEntry&))]
			[CallsDeduplicatedMethods(Count = 1)]
			[Token(Token = "0x6000023")]
			internal get { } //Length: 131
		}

		[Token(Token = "0x17000004")]
		public override Allocator ToAllocator
		{
			[Address(RVA = "0x181F6E0", Offset = "0x181E8E0", Length = "0xD")]
			[CallerCount(Count = 0)]
			[Token(Token = "0x6000029")]
			 get { } //Length: 13
		}

		[Token(Token = "0x17000002")]
		public int Value
		{
			[Address(RVA = "0x7C8EA0", Offset = "0x7C80A0", Length = "0x4")]
			[CallerCount(Count = 9)]
			[DeduplicatedMethod]
			[Token(Token = "0x6000026")]
			 get { } //Length: 4
		}

		[Address(RVA = "0x140E480", Offset = "0x140D680", Length = "0x9")]
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x600002E")]
		public override int CompareTo(AllocatorHandle other) { }

		[Address(RVA = "0x181F4D0", Offset = "0x181E6D0", Length = "0x16")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AllocatorHandle), Member = "get_TableEntry", ReturnType = typeof(TableEntry&))]
		[Token(Token = "0x600002A")]
		public override void Dispose() { }

		[Address(RVA = "0x181F4F0", Offset = "0x181E6F0", Length = "0xF1")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600002B")]
		public virtual bool Equals(object obj) { }

		[Address(RVA = "0x140E7E0", Offset = "0x140D9E0", Length = "0x7")]
		[CallerCount(Count = 1)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x600002C")]
		public override bool Equals(AllocatorHandle other) { }

		[Address(RVA = "0x344910", Offset = "0x343B10", Length = "0x3")]
		[CallerCount(Count = 129)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000028")]
		public override AllocatorHandle get_Handle() { }

		[Address(RVA = "0x181F650", Offset = "0x181E850", Length = "0x83")]
		[CalledBy(Type = typeof(AllocatorHandle), Member = "Dispose", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(AllocatorManager), Member = "allocate_block", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Block&)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(AllocatorManager), Member = "forward_mono_allocate_block", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Block&), typeof(Int32&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(AllocatorManager), Member = "Try", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Block&)}, ReturnType = typeof(int))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Unity.Collections.AllocatorManager+Array32768`1<Unity.Collections.AllocatorManager+TableEntry>), Member = "ElementAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(TableEntry&))]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000023")]
		internal TableEntry get_TableEntry() { }

		[Address(RVA = "0x181F6E0", Offset = "0x181E8E0", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000029")]
		public override Allocator get_ToAllocator() { }

		[Address(RVA = "0x7C8EA0", Offset = "0x7C80A0", Length = "0x4")]
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000026")]
		public int get_Value() { }

		[Address(RVA = "0x7C8EA0", Offset = "0x7C80A0", Length = "0x4")]
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		[Token(Token = "0x600002D")]
		public virtual int GetHashCode() { }

		[Address(RVA = "0x181F6F0", Offset = "0x181E8F0", Length = "0x11")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000025")]
		public static AllocatorHandle op_Implicit(Allocator a) { }

		[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
		[CallerCount(Count = 8626)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000024")]
		internal void Rewind() { }

		[Address(RVA = "0x181F5F0", Offset = "0x181E7F0", Length = "0x5A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(AllocatorManager), Member = "Try", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Block&)}, ReturnType = typeof(int))]
		[Token(Token = "0x6000027")]
		public override int Try(ref Block block) { }

	}

	[Token(Token = "0x2000012")]
	public struct Array16
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400001B")]
		internal T f0; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400001C")]
		internal T f1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400001D")]
		internal T f2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400001E")]
		internal T f3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400001F")]
		internal T f4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000020")]
		internal T f5; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000021")]
		internal T f6; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000022")]
		internal T f7; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000023")]
		internal T f8; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000024")]
		internal T f9; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000025")]
		internal T f10; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000026")]
		internal T f11; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000027")]
		internal T f12; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000028")]
		internal T f13; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000029")]
		internal T f14; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400002A")]
		internal T f15; //Field offset: 0x0

	}

	[Token(Token = "0x2000013")]
	public struct Array256
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400002B")]
		internal Array16<T> f0; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400002C")]
		internal Array16<T> f1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400002D")]
		internal Array16<T> f2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400002E")]
		internal Array16<T> f3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400002F")]
		internal Array16<T> f4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000030")]
		internal Array16<T> f5; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000031")]
		internal Array16<T> f6; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000032")]
		internal Array16<T> f7; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000033")]
		internal Array16<T> f8; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000034")]
		internal Array16<T> f9; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000035")]
		internal Array16<T> f10; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000036")]
		internal Array16<T> f11; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000037")]
		internal Array16<T> f12; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000038")]
		internal Array16<T> f13; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000039")]
		internal Array16<T> f14; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400003A")]
		internal Array16<T> f15; //Field offset: 0x0

	}

	[Token(Token = "0x2000015")]
	public struct Array32768 : IIndexable<T>
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400004B")]
		internal Array4096<T> f0; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400004C")]
		internal Array4096<T> f1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400004D")]
		internal Array4096<T> f2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400004E")]
		internal Array4096<T> f3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400004F")]
		internal Array4096<T> f4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000050")]
		internal Array4096<T> f5; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000051")]
		internal Array4096<T> f6; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000052")]
		internal Array4096<T> f7; //Field offset: 0x0

		[Token(Token = "0x17000009")]
		public override int Length
		{
			[Address(RVA = "0xAF6BD0", Offset = "0xAF5DD0", Length = "0x6")]
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			[Token(Token = "0x6000038")]
			 get { } //Length: 6
		}

		[Address(RVA = "0xAF6AA0", Offset = "0xAF5CA0", Length = "0xE8")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE460")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000039")]
		public override T ElementAt(int index) { }

		[Address(RVA = "0xAF6BD0", Offset = "0xAF5DD0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000038")]
		public override int get_Length() { }

	}

	[Token(Token = "0x2000014")]
	public struct Array4096
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400003B")]
		internal Array256<T> f0; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400003C")]
		internal Array256<T> f1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400003D")]
		internal Array256<T> f2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400003E")]
		internal Array256<T> f3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400003F")]
		internal Array256<T> f4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000040")]
		internal Array256<T> f5; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000041")]
		internal Array256<T> f6; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000042")]
		internal Array256<T> f7; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000043")]
		internal Array256<T> f8; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000044")]
		internal Array256<T> f9; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000045")]
		internal Array256<T> f10; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000046")]
		internal Array256<T> f11; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000047")]
		internal Array256<T> f12; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000048")]
		internal Array256<T> f13; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000049")]
		internal Array256<T> f14; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400004A")]
		internal Array256<T> f15; //Field offset: 0x0

	}

	[Token(Token = "0x200000F")]
	internal struct Block : IDisposable
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000012")]
		public Range Range; //Field offset: 0x0
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000013")]
		public int BytesPerItem; //Field offset: 0x10
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x4000014")]
		public int AllocatedItems; //Field offset: 0x14
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000015")]
		public byte Log2Alignment; //Field offset: 0x18
		[FieldOffset(Offset = "0x19")]
		[Token(Token = "0x4000016")]
		public byte Padding0; //Field offset: 0x19
		[FieldOffset(Offset = "0x1A")]
		[Token(Token = "0x4000017")]
		public ushort Padding1; //Field offset: 0x1A
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x4000018")]
		public uint Padding2; //Field offset: 0x1C

		[Token(Token = "0x17000007")]
		public int Alignment
		{
			[Address(RVA = "0x1820340", Offset = "0x181F540", Length = "0xC")]
			[CallerCount(Count = 0)]
			[Token(Token = "0x6000032")]
			 get { } //Length: 12
			[Address(RVA = "0x1820370", Offset = "0x181F570", Length = "0x4B")]
			[CalledBy(Type = typeof(AllocatorManager), Member = "AllocateBlock", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(Block))]
			[CalledBy(Type = typeof(AllocatorManager), Member = "Free", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(Void*), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
			[CallerCount(Count = 2)]
			[ContainsUnimplementedInstructions]
			[Token(Token = "0x6000033")]
			 set { } //Length: 75
		}

		[Token(Token = "0x17000006")]
		public long AllocatedBytes
		{
			[Address(RVA = "0x1820350", Offset = "0x181F550", Length = "0xD")]
			[CallerCount(Count = 0)]
			[Token(Token = "0x6000031")]
			 get { } //Length: 13
		}

		[Token(Token = "0x17000005")]
		public long Bytes
		{
			[Address(RVA = "0x1820360", Offset = "0x181F560", Length = "0xD")]
			[CallerCount(Count = 0)]
			[Token(Token = "0x6000030")]
			 get { } //Length: 13
		}

		[Address(RVA = "0x18202F0", Offset = "0x181F4F0", Length = "0x50")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(AllocatorManager), Member = "Try", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Block&)}, ReturnType = typeof(int))]
		[DeduplicatedMethod]
		[Token(Token = "0x6000034")]
		public override void Dispose() { }

		[Address(RVA = "0x1820340", Offset = "0x181F540", Length = "0xC")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000032")]
		public int get_Alignment() { }

		[Address(RVA = "0x1820350", Offset = "0x181F550", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000031")]
		public long get_AllocatedBytes() { }

		[Address(RVA = "0x1820360", Offset = "0x181F560", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000030")]
		public long get_Bytes() { }

		[Address(RVA = "0x1820370", Offset = "0x181F570", Length = "0x4B")]
		[CalledBy(Type = typeof(AllocatorManager), Member = "AllocateBlock", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(Block))]
		[CalledBy(Type = typeof(AllocatorManager), Member = "Free", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(Void*), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000033")]
		public void set_Alignment(int value) { }

		[Address(RVA = "0x18202F0", Offset = "0x181F4F0", Length = "0x50")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(AllocatorManager), Member = "Try", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Block&)}, ReturnType = typeof(int))]
		[DeduplicatedMethod]
		[Token(Token = "0x6000035")]
		public int TryFree() { }

	}

	[Token(Token = "0x2000010")]
	internal interface IAllocator : IDisposable
	{

		[Token(Token = "0x17000008")]
		public AllocatorHandle Handle
		{
			[Token(Token = "0x6000037")]
			 get { } //Length: 0
		}

		[Token(Token = "0x6000037")]
		public AllocatorHandle get_Handle() { }

		[Token(Token = "0x6000036")]
		public int Try(ref Block block) { }

	}

	[Token(Token = "0x2000018")]
	public static class Managed
	{
		[Token(Token = "0x4000054")]
		internal static TryFunction[] TryFunctionDelegates; //Field offset: 0x0

		[Address(RVA = "0x1820620", Offset = "0x181F820", Length = "0x68")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x600003B")]
		private static Managed() { }

	}

	[Token(Token = "0x200000E")]
	internal struct Range : IDisposable
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400000F")]
		public IntPtr Pointer; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000010")]
		public int Items; //Field offset: 0x8
		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x4000011")]
		public AllocatorHandle Allocator; //Field offset: 0xC

		[Address(RVA = "0x1820990", Offset = "0x181FB90", Length = "0x71")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(AllocatorManager), Member = "Try", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Block&)}, ReturnType = typeof(int))]
		[Token(Token = "0x600002F")]
		public override void Dispose() { }

	}

	[Token(Token = "0x2000016")]
	public sealed class SharedStatics
	{
		[Token(Token = "0x2000017")]
		public sealed class TableEntry
		{
			[Token(Token = "0x4000053")]
			internal static readonly SharedStatic<Array32768`1<TableEntry>> Ref; //Field offset: 0x0

			[Address(RVA = "0x1820A90", Offset = "0x181FC90", Length = "0x5D")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(SharedStatic`1), Member = "GetOrCreateUnsafe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(long), typeof(long)}, ReturnType = "Unity.Burst.SharedStatic`1<T>")]
			[Token(Token = "0x600003A")]
			private static TableEntry() { }

		}


	}

	[Token(Token = "0x2000011")]
	public struct TableEntry
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000019")]
		internal IntPtr function; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400001A")]
		internal IntPtr state; //Field offset: 0x8

	}

	[Token(Token = "0x200000C")]
	[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
	internal sealed class TryFunction : MulticastDelegate
	{

		[Address(RVA = "0x391980", Offset = "0x390B80", Length = "0xA6")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000021")]
		public TryFunction(object object, IntPtr method) { }

		[Address(RVA = "0x335340", Offset = "0x334540", Length = "0xF")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000022")]
		public override int Invoke(IntPtr allocatorState, ref Block block) { }

	}

	[Token(Token = "0x4000003")]
	public static readonly AllocatorHandle Invalid; //Field offset: 0x0
	[Token(Token = "0x4000004")]
	public static readonly AllocatorHandle None; //Field offset: 0x4
	[Token(Token = "0x4000005")]
	public static readonly AllocatorHandle Temp; //Field offset: 0x8
	[Token(Token = "0x4000006")]
	public static readonly AllocatorHandle TempJob; //Field offset: 0xC
	[Token(Token = "0x4000007")]
	public static readonly AllocatorHandle Persistent; //Field offset: 0x10
	[Token(Token = "0x4000008")]
	public static readonly AllocatorHandle AudioKernel; //Field offset: 0x14
	[Token(Token = "0x4000009")]
	internal static readonly ushort NumGlobalScratchAllocators; //Field offset: 0x18
	[Token(Token = "0x400000A")]
	internal static readonly ushort MaxNumGlobalAllocators; //Field offset: 0x1A
	[Token(Token = "0x400000B")]
	internal static readonly uint GlobalAllocatorBaseIndex; //Field offset: 0x1C
	[Token(Token = "0x400000C")]
	internal static readonly uint FirstGlobalScratchpadAllocatorIndex; //Field offset: 0x20

	[Address(RVA = "0x181FD00", Offset = "0x181EF00", Length = "0x148")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(JobsUtility), Member = "get_ThreadIndexCount", ReturnType = typeof(int))]
	[Token(Token = "0x6000020")]
	private static AllocatorManager() { }

	[Address(RVA = "0x181FE50", Offset = "0x181F050", Length = "0x87")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(AllocatorHandle), Member = "get_TableEntry", ReturnType = typeof(TableEntry&))]
	[Calls(Type = typeof(FunctionPointer`1), Member = "get_Invoke", ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600001B")]
	private static int allocate_block(ref Block block) { }

	[Address(RVA = "0x60A0B0", Offset = "0x6092B0", Length = "0x1A4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180282E20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEB00")]
	[Calls(Type = typeof(Block), Member = "set_Alignment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Extension]
	[Token(Token = "0x6000013")]
	internal static Block AllocateBlock(ref T t, int sizeOf, int alignOf, int items) { }

	[Address(RVA = "0x181F710", Offset = "0x181E910", Length = "0x4")]
	[BurstDiscard]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000019")]
	private static void CheckDelegate(ref bool useDelegate) { }

	[Address(RVA = "0x181FEE0", Offset = "0x181F0E0", Length = "0x110")]
	[BurstDiscard]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(AllocatorHandle), Member = "get_TableEntry", ReturnType = typeof(TableEntry&))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600001C")]
	private static void forward_mono_allocate_block(ref Block block, ref int error) { }

	[Address(RVA = "0x60A8C0", Offset = "0x609AC0", Length = "0xCE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(Block), Member = "set_Alignment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Extension]
	[Token(Token = "0x6000015")]
	internal static void Free(ref T t, Void* pointer, int sizeOf, int alignOf, int items) { }

	[Address(RVA = "0x60A780", Offset = "0x609980", Length = "0xBD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[Extension]
	[Token(Token = "0x6000016")]
	internal static void Free(ref T t, U* pointer, int items) { }

	[Address(RVA = "0x181F720", Offset = "0x181E920", Length = "0x69")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(AllocatorManager), Member = "Free", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AllocatorHandle), typeof(byte)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AllocatorHandle&), typeof(Byte*), typeof(int)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000017")]
	public static void Free(AllocatorHandle handle, Void* pointer) { }

	[Address(RVA = "0x60AA80", Offset = "0x609C80", Length = "0xE2")]
	[CalledBy(Type = typeof(UnsafeList`1), Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.LowLevel.Unsafe.UnsafeList`1<T>*"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(UnsafeUtility), Member = "AlignOf", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180023070")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000018")]
	public static void Free(AllocatorHandle handle, T* pointer, int items = 1) { }

	[Address(RVA = "0x60A2B0", Offset = "0x6094B0", Length = "0xCF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180282E20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEB00")]
	[DeduplicatedMethod]
	[Extension]
	[Token(Token = "0x6000014")]
	internal static void FreeBlock(ref T t, ref Block block) { }

	[Address(RVA = "0x181F790", Offset = "0x181E990", Length = "0xF")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600001D")]
	internal static Allocator LegacyOf(AllocatorHandle handle) { }

	[Address(RVA = "0x181F950", Offset = "0x181EB50", Length = "0x360")]
	[CalledBy(Type = typeof(UnsafeStream), Member = "Deallocate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AllocatorHandle), Member = "Try", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Block&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Range), Member = "Dispose", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Block), Member = "Dispose", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Block), Member = "TryFree", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Array), Member = "CustomResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(long), typeof(long), typeof(AllocatorHandle), typeof(long), typeof(int)}, ReturnType = typeof(Void*))]
	[CalledBy(Type = typeof(Array), Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(long), typeof(long), typeof(AllocatorHandle), typeof(long), typeof(int)}, ReturnType = typeof(Void*))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(Array), Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(long), typeof(long), typeof(AllocatorHandle), typeof(long), typeof(int)}, ReturnType = typeof(Void*))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(AllocatorHandle), Member = "get_TableEntry", ReturnType = typeof(TableEntry&))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600001F")]
	public static int Try(ref Block block) { }

	[Address(RVA = "0x181F7A0", Offset = "0x181E9A0", Length = "0x1A8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Array), Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(long), typeof(long), typeof(AllocatorHandle), typeof(long), typeof(int)}, ReturnType = typeof(Void*))]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600001E")]
	private static int TryLegacy(ref Block block) { }

	[Address(RVA = "0x181FCC0", Offset = "0x181EEC0", Length = "0x3C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x600001A")]
	private static bool UseDelegate() { }

}

