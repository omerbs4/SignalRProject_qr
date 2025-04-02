using AutoMapper;
using SignalR.DtoLayer.TestimonialDto;
using SignalR.EntitiyLayer.Entities;

namespace SignalRApi.Mapping
{
    public class TestimonialMapping: Profile
    {
        public TestimonialMapping()
        {
            CreateMap<Testimonial, ResultTestimonialDto>().ReverseMap();
            CreateMap<Testimonial, CreateTestimonialDto>().ReverseMap();
            CreateMap<Testimonial, GetTestimonialDto>().ReverseMap();
            CreateMap<Testimonial, UpdateTestimonialDto>().ReverseMap();
        }
    }
}
