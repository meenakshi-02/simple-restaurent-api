using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using restaurent.Data;
using restaurent.Dto;
using restaurent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace restaurent.Controllers
{
    [ApiController]
    [Route("api")]
    public class restaurentapiController : ControllerBase
    {
        private readonly Irestaurentrepo _repository;
        private readonly IMapper _mapper;
        public restaurentapiController(Irestaurentrepo repository,IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        
      
        //Customer
        [HttpGet("getcustomer")]
        public ActionResult<IEnumerable<CustomerReadDto>> GetAllCustomer()
        {
            var customerlist = _repository.GetAllCustomer();
            return Ok(_mapper.Map<IEnumerable<CustomerReadDto>>(customerlist));
        }

        [HttpGet("getcustomer/{id}")]
        public ActionResult<CustomerReadDto> GetCustomerById(int id)
        {
            var customerbyid = _repository.GetCustomerById(id);
            if (customerbyid != null) return Ok(_mapper.Map<CustomerReadDto>(customerbyid));
            else return NotFound();
        }

        [HttpPost("createcustomer")]
        public ActionResult<CustomerReadDto> CreateCustomer(CustomerCreateDto customerCreateDto)
        {
            var customerModel = _mapper.Map<Customer>(customerCreateDto);
            _repository.CreateCustomer(customerModel);
            _repository.SaveChanges();

            var customerReadDto = _mapper.Map<CustomerReadDto>(customerModel);

            return CreatedAtRoute(nameof(GetCustomerById), new { Id = customerReadDto.Id }, customerReadDto);
        }

        [HttpPut("updatecustomer/{id}")]
        public ActionResult UpdateCustomer(int id, CustomerCreateDto customerUpdateDto)
        {
            var customerModelFromRepo = _repository.GetCustomerById(id);
            if (customerModelFromRepo == null)
            {
                return NotFound();
            }
            _mapper.Map(customerUpdateDto, customerModelFromRepo);

            _repository.UpdateCustomer(customerModelFromRepo);

            _repository.SaveChanges();

            return NoContent();
        }

        [HttpDelete("deletecustomer/{id}")]
        public ActionResult DeleteCustomer(int id)
        {
            var customerModelFromRepo = _repository.GetCustomerById(id);
            if (customerModelFromRepo == null)
            {
                return NotFound();
            }
            _repository.DeleteCustomer(customerModelFromRepo);
            _repository.SaveChanges();

            return NoContent();
        }


        //MenuItem
        [HttpGet("getmenuitem")]
        public ActionResult<IEnumerable<MenuItemReadDto>> GetAllMenuItem()
        {
            var menuitemlist = _repository.GetAllMenuItem();
            return Ok(_mapper.Map<IEnumerable<MenuItemReadDto>>(menuitemlist));
        }


        //Order
        [HttpGet("getorder")]
        public ActionResult<IEnumerable<OrderReadDto>> GetAllOrder()
        {
            var orderlist = _repository.GetAllOrder();
            return Ok(_mapper.Map<IEnumerable<OrderReadDto>>(orderlist));
        }

        [HttpGet("getorder/{id}")]
        public ActionResult<OrderReadDto> GetOrderById(int id)
        {
            var orderbyid = _repository.GetOrderById(id);
            if (orderbyid != null) return Ok(_mapper.Map<OrderReadDto>(orderbyid));
            else return NotFound();
        }

        [HttpPost("createorder")]
        public ActionResult<OrderReadDto> CreateOrder(OrderCreateDto orderCreateDto)
        {
            var orderModel = _mapper.Map<Order>(orderCreateDto);
            _repository.CreateOrder(orderModel);
            _repository.SaveChanges();

            var orderReadDto = _mapper.Map<OrderReadDto>(orderModel);

            return CreatedAtRoute(nameof(GetOrderById), new { Id = orderReadDto.Id }, orderReadDto);
        }


        //Transaction
        [HttpGet("gettransaction")]
        public ActionResult<IEnumerable<TransactionReadDto>> GetAllTransaction()
        {
            var transactionlist = _repository.GetAllTransaction();
            return Ok(_mapper.Map<IEnumerable<TransactionReadDto>>(transactionlist));
        }

        [HttpGet("gettransaction/{id}")]
        public ActionResult<TransactionReadDto> GetTransactionById(int id)
        {
            var transactionbyid = _repository.GetTransactionById(id);
            if (transactionbyid != null) return Ok(_mapper.Map<TransactionReadDto>(transactionbyid));
            else return NotFound();
        }

        [HttpPost("createtransaction")]
        public ActionResult<TransactionReadDto> CreateTransaction(TransactionCreateDto transactionCreateDto)
        {
            var transactionModel = _mapper.Map<Transaction>(transactionCreateDto);
            _repository.CreateTransaction(transactionModel);
            _repository.SaveChanges();

            var transactionReadDto = _mapper.Map<TransactionReadDto>(transactionModel);

            return CreatedAtAction(nameof(GetTransactionById), new { Id = transactionReadDto.Id }, transactionReadDto);
        }

    }
}
