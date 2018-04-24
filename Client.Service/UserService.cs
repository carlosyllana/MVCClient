using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Client.Service
{
    public class UserService : IUserService
    {
        private readonly HttpClient _cliente;

        public UserService()
        {
           
            _cliente = ServiceConfiguration.InitClient(new HttpClient());

        }

        public async Task<UserServiceModel> GetAsync()
        {
            try
            {
                var response = await _cliente.GetAsync("/api/v1/UserAsync/GetAsync",HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false);
                response.EnsureSuccessStatusCode();
                using (var content = response.Content)
                {
                    var x = await response.Content.ReadAsAsync<UserServiceModel>();
                    return x;
                }
                
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public async Task<UserServiceModel> SetAsync(UserServiceModel user)
        {
            try
            {

                var response = await _cliente.PostAsJsonAsync<UserServiceModel>("/api/v1/UserAsync/AddAsync", user ).ConfigureAwait(false);
                response.EnsureSuccessStatusCode();
                using (var Content = response.Content)
                {
                    return await Content.ReadAsAsync<UserServiceModel>();
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
