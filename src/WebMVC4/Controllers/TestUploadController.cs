namespace WebMVC4.Controllers
{
    using System;
    using System.Globalization;
    using System.Web.Mvc;
    using Agenda.Model;
    using Common.Controllers.Upload;

    public class TestUploadController : BaseUploader<string>
    {
        public TestUploadController()
            : base(
                new BlobStorage<AgendaContext, BlobFile>(
                    a => a.Blob,
                    a => a.Id.ToString(CultureInfo.InvariantCulture),
                    OnSave),
                new FileExtensionValidator(
                    new[]
                    {
                        "jpg", 
                        "jpeg", 
                        "png", 
                        "gif", 
                        "bmp", 
                        "pdf", 
                        "doc", 
                        "docx", 
                        "xls", 
                        "xlsx"
                    }))
        {
        }

        private static void OnSave(Controller controller, string identifier, BlobFile file)
        {
            file.NomeFile = identifier;
            file.DataUpload = DateTime.Now;
            file.UserId = "APEX";
        }
    }
}
