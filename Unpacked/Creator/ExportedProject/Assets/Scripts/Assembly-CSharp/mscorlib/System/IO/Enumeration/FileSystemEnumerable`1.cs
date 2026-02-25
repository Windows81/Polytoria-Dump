namespace System.IO.Enumeration;

[Token(Token = "0x2000669")]
public class FileSystemEnumerable : IEnumerable<TResult>, IEnumerable
{
	[Token(Token = "0x200066C")]
	private sealed class DelegateEnumerator : FileSystemEnumerator<TResult>
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001A2C")]
		private readonly FileSystemEnumerable<TResult> _enumerable; //Field offset: 0x0

		[Address(RVA = "0x9E7150", Offset = "0x9E6350", Length = "0x50")]
		[CalledBy(Type = typeof(FileSystemEnumerable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "System.IO.Enumeration.FileSystemEnumerable`1<TResult>+FindTransform<TResult>", typeof(EnumerationOptions)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FileSystemEnumerable`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.IEnumerator`1<TResult>")]
		[CalledBy(Type = typeof(FileSystemEnumerable`1), Member = "System.Collections.IEnumerable.GetEnumerator", ReturnType = typeof(IEnumerator))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(FileSystemEnumerator`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(EnumerationOptions)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002FCA")]
		public DelegateEnumerator(FileSystemEnumerable<TResult> enumerable) { }

		[Address(RVA = "0x9E6E90", Offset = "0x9E6090", Length = "0x35")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002FCD")]
		protected virtual bool ShouldIncludeEntry(ref FileSystemEntry entry) { }

		[Address(RVA = "0x9E6F60", Offset = "0x9E6160", Length = "0x35")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002FCC")]
		protected virtual bool ShouldRecurseIntoEntry(ref FileSystemEntry entry) { }

		[Address(RVA = "0x9E7090", Offset = "0x9E6290", Length = "0x2E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002FCB")]
		protected virtual TResult TransformEntry(ref FileSystemEntry entry) { }

	}

	[Token(Token = "0x200066A")]
	internal sealed class FindPredicate : MulticastDelegate
	{

		[Address(RVA = "0x395C60", Offset = "0x394E60", Length = "0xB4")]
		[CallerCount(Count = 72)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002FC6")]
		public FindPredicate(object object, IntPtr method) { }

		[Address(RVA = "0x309260", Offset = "0x308460", Length = "0xF")]
		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002FC7")]
		public override bool Invoke(ref FileSystemEntry entry) { }

	}

	[Token(Token = "0x200066B")]
	internal sealed class FindTransform : MulticastDelegate
	{

		[Address(RVA = "0xC3F670", Offset = "0xC3E870", Length = "0xB4")]
		[CallerCount(Count = 84)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002FC8")]
		public FindTransform(object object, IntPtr method) { }

		[Address(RVA = "0x309260", Offset = "0x308460", Length = "0xF")]
		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002FC9")]
		public override TResult Invoke(ref FileSystemEntry entry) { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001A26")]
	private DelegateEnumerator<TResult> _enumerator; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001A27")]
	private readonly FindTransform<TResult> _transform; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001A28")]
	private readonly EnumerationOptions _options; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001A29")]
	private readonly string _directory; //Field offset: 0x0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001A2A")]
	private FindPredicate<TResult> <ShouldIncludePredicate>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001A2B")]
	private FindPredicate<TResult> <ShouldRecursePredicate>k__BackingField; //Field offset: 0x0

	[Token(Token = "0x17000759")]
	public FindPredicate<TResult> ShouldIncludePredicate
	{
		[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
		[CallerCount(Count = 27)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6002FC1")]
		 get { } //Length: 95
		[Address(RVA = "0x2F8470", Offset = "0x2F7670", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6002FC2")]
		 set { } //Length: 13
	}

	[Token(Token = "0x1700075A")]
	public FindPredicate<TResult> ShouldRecursePredicate
	{
		[Address(RVA = "0x309610", Offset = "0x308810", Length = "0x5")]
		[CallerCount(Count = 16)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6002FC3")]
		 get { } //Length: 5
	}

	[Address(RVA = "0xC3B3A0", Offset = "0xC3A5A0", Length = "0x1A5")]
	[CalledBy(Type = typeof(FileSystemEnumerableFactory), Member = "UserFiles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(EnumerationOptions)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.String>))]
	[CalledBy(Type = typeof(FileSystemEnumerableFactory), Member = "UserDirectories", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(EnumerationOptions)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.String>))]
	[CalledBy(Type = typeof(FileSystemEnumerableFactory), Member = "UserEntries", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(EnumerationOptions)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.String>))]
	[CalledBy(Type = typeof(FileSystemEnumerableFactory), Member = "FileInfos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(EnumerationOptions)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.IO.FileInfo>))]
	[CalledBy(Type = typeof(FileSystemEnumerableFactory), Member = "DirectoryInfos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(EnumerationOptions)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.IO.DirectoryInfo>))]
	[CalledBy(Type = typeof(FileSystemEnumerableFactory), Member = "FileSystemInfos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(EnumerationOptions)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.IO.FileSystemInfo>))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(DelegateEnumerator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.IO.Enumeration.FileSystemEnumerable`1<TResult>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180C274C0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002FC0")]
	public FileSystemEnumerable`1(string directory, FindTransform<TResult> transform, EnumerationOptions options = null) { }

	[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
	[CallerCount(Count = 27)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6002FC1")]
	public FindPredicate<TResult> get_ShouldIncludePredicate() { }

	[Address(RVA = "0x309610", Offset = "0x308810", Length = "0x5")]
	[CallerCount(Count = 16)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6002FC3")]
	public FindPredicate<TResult> get_ShouldRecursePredicate() { }

	[Address(RVA = "0xC3B0E0", Offset = "0xC3A2E0", Length = "0x7D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(DelegateEnumerator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.IO.Enumeration.FileSystemEnumerable`1<TResult>"}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6002FC4")]
	public override IEnumerator<TResult> GetEnumerator() { }

	[Address(RVA = "0x2F8470", Offset = "0x2F7670", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6002FC2")]
	public void set_ShouldIncludePredicate(FindPredicate<TResult> value) { }

	[Address(RVA = "0xC3B160", Offset = "0xC3A360", Length = "0x89")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(DelegateEnumerator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.IO.Enumeration.FileSystemEnumerable`1<TResult>"}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6002FC5")]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

