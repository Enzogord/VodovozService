﻿using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.ServiceModel;
using System.ServiceModel.Web;
using Vodovoz.MobileService.DTO;

namespace Vodovoz.MobileService
{
    [ServiceContract]
	public interface IMobileService
	{
		[OperationContract]
		[WebGet(UriTemplate = "/Catalog/{type}/", ResponseFormat = WebMessageFormat.Json)]
		List<NomenclatureDTO> GetGoods(CatalogType type);

		[OperationContract]
		[WebGet(UriTemplate = "/Catalog/Images/{filename}", ResponseFormat = WebMessageFormat.Json)]
		Stream GetImage(string filename);
	}
}
