using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using NPLubricants.Models;

namespace NPLubricants.Components.Pages
{
    public partial class TestimonialPage
    {
        [Inject] IJSRuntime JSRuntime { get; set; }
        public TestimonialList testimonials { get; set; } = new TestimonialList();

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                await JSRuntime.InvokeVoidAsync("eval", @"
                var swiper = new Swiper('.valuable-client-swiper', {
                    loop: true,
                    autoplay: {
                        delay: 4000,
                        disableOnInteraction: false
                    },
                    navigation: {
                        nextEl: '.swiper-button-next',
                        prevEl: '.swiper-button-prev'
                    },
                    pagination: {
                        el: '.swiper-pagination',
                        clickable: true
                    }
                });
            ");
            }
        }
    }
}