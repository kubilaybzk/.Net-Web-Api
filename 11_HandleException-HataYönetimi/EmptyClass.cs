using System;
namespace _11_HandleException_HataYönetimi
{
	public class RecordNotFoundException:Exception
    {
		public RecordNotFoundException(string Message):base(Message)
		{
		}
	}
}

