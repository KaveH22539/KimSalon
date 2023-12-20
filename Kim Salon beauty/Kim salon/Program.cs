namespace HairDres
{
    using System;

    class Program
    {
        static void Main()
        {
            //Instantiate services
            CustomerService customerService = new CustomerService();
            BookingService bookingService = new BookingService();
            ServiceService serviceService = new ServiceService();

            //Sample data
            Customer customer = new Customer(1, "Ronaldo", "123-456-7890");
            Booking booking = new Booking
            {
                AppointmentID = 1,
                Date = DateTime.Now.Date,
                Time = new TimeSpan(14, 30, 0),
                ServiceType = "Haircut",
                CustomerID = customer.CustomerID,
                Status = "Scheduled"
            };
            Service service = new Service ( 1, "Haircut", 25.99m );

            //Adding a customer
            customerService.AddCustomer(customer);

            //Updating a customer
            customer.Name = "Updated Name";
            customerService.UpdateCustomer(customer);

            //Getting a customer
           Customer retrievedCustomer = customerService.GetCustomer(customer.CustomerID);
            if (retrievedCustomer != null)
            {
                Console.WriteLine($"Retrieved Customer: {retrievedCustomer.Name}");
            }

            //Adding a booking
            bookingService.AddBooking(booking);

            //Updating a booking
            booking.Status = "Completed";
            bookingService.UpdateBooking(booking);

            //Getting a booking
           Booking retrievedBooking = bookingService.GetBooking(booking.AppointmentID);
            if (retrievedBooking != null)
            {
                Console.WriteLine($"Retrieved Booking Status: {retrievedBooking.Status}");
            }

            //Adding a service
            serviceService.AddService(service);

            //Updating a service
            service.Description = "Updated Haircut";
            serviceService.UpdateService(service);

            //Getting a service
           Service retrievedService = serviceService.GetService(service.ServiceID);
            if (retrievedService != null)
            {
                Console.WriteLine($"Retrieved Service: {retrievedService.Description}");
            }

            //Deleting a service
            serviceService.DeleteService(service.ServiceID);

            //Deleting a booking
            bookingService.DeleteBooking(booking.AppointmentID);

            //Deleting a customer
            customerService.DeleteCustomer(customer.CustomerID);

            
        }
    }

}
