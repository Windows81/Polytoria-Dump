namespace System.Net.Cache;

[Token(Token = "0x20002DB")]
public enum RequestCacheLevel
{
	Default = 0,
	BypassCache = 1,
	CacheOnly = 2,
	CacheIfAvailable = 3,
	Revalidate = 4,
	Reload = 5,
	NoCacheNoStore = 6,
}

