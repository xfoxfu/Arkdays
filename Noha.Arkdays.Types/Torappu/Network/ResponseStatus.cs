
namespace Torappu.Network
{
	public enum ResponseStatus
	{
		OK,
		ERROR_IGNORE,
		ERROR_RETRY,
		ERROR_SYNC_DATA,
		ERROR_RELOGIN,
		ERROR_TIMEOUT,
		ERROR_CLIENT,
		CANCEL,
		ERROR_SECURE_SYS,
		ERROR_UNKNOW
	}
}
