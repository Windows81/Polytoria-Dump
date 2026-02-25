namespace System.IO;

[Extension]
[Token(Token = "0x2000666")]
internal static class MonoLinqHelper
{

	[Address(RVA = "0x705170", Offset = "0x704370", Length = "0x39")]
	[CalledBy(Type = typeof(Directory), Member = "GetFileSystemEntries", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(EnumerationOptions)}, ReturnType = typeof(String[]))]
	[CalledBy(Type = typeof(DirectoryInfo), Member = "GetDirectories", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(EnumerationOptions)}, ReturnType = typeof(DirectoryInfo[]))]
	[CalledBy(Type = typeof(Directory), Member = "GetFiles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(String[]))]
	[CalledBy(Type = typeof(Directory), Member = "GetFiles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(EnumerationOptions)}, ReturnType = typeof(String[]))]
	[CalledBy(Type = typeof(Directory), Member = "GetDirectories", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(String[]))]
	[CalledBy(Type = typeof(Directory), Member = "GetDirectories", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(EnumerationOptions)}, ReturnType = typeof(String[]))]
	[CalledBy(Type = typeof(Directory), Member = "GetFileSystemEntries", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(String[]))]
	[CalledBy(Type = typeof(DirectoryInfo), Member = "GetDirectories", ReturnType = typeof(DirectoryInfo[]))]
	[CalledBy(Type = typeof(DirectoryInfo), Member = "GetFiles", ReturnType = typeof(FileInfo[]))]
	[CalledBy(Type = typeof(DirectoryInfo), Member = "GetFiles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(EnumerationOptions)}, ReturnType = typeof(FileInfo[]))]
	[CalledBy(Type = typeof(DirectoryInfo), Member = "GetFileSystemInfos", ReturnType = typeof(FileSystemInfo[]))]
	[CalledBy(Type = typeof(DirectoryInfo), Member = "GetFileSystemInfos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(EnumerationOptions)}, ReturnType = typeof(FileSystemInfo[]))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(EnumerableHelpers), Member = "ToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<T>"}, ReturnType = "T[]")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[DeduplicatedMethod]
	[Extension]
	[Token(Token = "0x6002F9B")]
	public static T[] ToArray(IEnumerable<T> source) { }

}

