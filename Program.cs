using System;
using System.Threading.Tasks;
using Amazon;
using Amazon.SQS;
using Amazon.SQS.Model;

namespace ConsoleApp3
{
	class Program
	{
		static void Main(string[] args)
		{
			sendMessagetoSQS();
		

		//	var result = SendMessage().Result;
		//	Console.WriteLine(result.HttpStatusCode);
		//	Console.ReadKey();

		}

		public static void sendMessagetoSQS()
		{
			var amazonSQSClient = new AmazonSQSClient(RegionEndpoint.USEast2);
			SendMessageRequest sendMessageRequest = new SendMessageRequest()
			{
				QueueUrl = "https://sqs.us-east-2.amazonaws.com/<accountNumber>/<data-queue-name>",
				MessageBody =
					"{\"d\":\"00000000-0000-0000-0000-00000000cc10\"}"
			};
			var result = amazonSQSClient.SendMessageAsync(sendMessageRequest).Result;
		}
		 
		public static async Task<SendMessageResponse> SendMessageToSQSAsync()
		{
			var amazonSQSClient = new AmazonSQSClient(RegionEndpoint.USEast2);
			SendMessageRequest sendMessageRequest = new SendMessageRequest()
			{
				QueueUrl = "https://sqs.us-east-2.amazonaws.com/<accountNumber>/<data-queue-name>",

				MessageBody =
					"{\"engagementId\":\"00000000-0000-0000-0000-00000000cc01\"}"
			};
			return await amazonSQSClient.SendMessageAsync(sendMessageRequest);
		}

	}


}
