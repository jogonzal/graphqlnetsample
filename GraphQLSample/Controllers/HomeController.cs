﻿using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using DataRepositories.Database;
using HtmlAgilityPack;

using Microsoft.AspNetCore.Mvc;

using Newtonsoft.Json;

namespace RcsServer.Controllers
{
	public class HomeController : Controller
	{
		private readonly EtisysContext _context;

		public HomeController(EtisysContext context)
		{
			_context = context;
		}

		private static HtmlNode CreateScriptElementWithSingleObject(string varName, object propertySet)
		{
			var htmlDoc = new HtmlDocument();
			HtmlNode elem = htmlDoc.CreateElement("script");

			var jsonString = JsonConvert.SerializeObject(propertySet);
			elem.AppendChild(htmlDoc.CreateTextNode($"var {varName} = {jsonString};"));

			return elem;
		}

		public string AppendScriptElementsToHtmlFile(string htmlFile, string pathAssetRoot, params HtmlNode[] scriptElementsToAdd)
		{
			var htmlDoc = new HtmlDocument();
			htmlDoc.LoadHtml(htmlFile);

			var head = htmlDoc.DocumentNode.SelectSingleNode("/html/head");

			// Uses the html served from the CDN with some adjustments
			if (scriptElementsToAdd != null)
			{
				foreach (var htmlNode in scriptElementsToAdd)
				{
					head.AppendChild(htmlNode);
				}
			}

			return htmlDoc.DocumentNode.OuterHtml;
		}

		public async Task<IActionResult> Index()
		{
			using (var httpClient = new HttpClient())
			{
				string indexHtmlUrl;
#if DEBUG
				indexHtmlUrl = "http://localhost:8080/index.html";
#else
				indexHtmlUrl = "https://jorgewebdeployment.blob.core.windows.net/graphqlsampleclient/index.html";
#endif
				var result = await httpClient.GetAsync(indexHtmlUrl);
				var rawHtml = await result.Content.ReadAsStringAsync();
				string transformedHtml = AppendScriptElementsToHtmlFile(rawHtml, indexHtmlUrl);

				return Content(transformedHtml, "text/html");
			}

			//return View(new HomeViewModel(AuthContext.GetCookie(HttpContext), AuthContext.GetCloudUser(HttpContext)));
		}

		public string Sample2()
		{
			var agentes = _context.Agentes.ToList();
			Debug.WriteLine($"I have ${agentes.Count} agentes");

			return "<html><body><p>Jorge</p></body></html>";
		}
	}
}
