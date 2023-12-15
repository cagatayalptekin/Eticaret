using Microsoft.AspNetCore.Components.Forms;
using System.Threading.Tasks;

namespace BlazorETicaret.Service
{
    public interface IFileUpload
    {
        Task<string> UploadFile(IBrowserFile file);
    }
}