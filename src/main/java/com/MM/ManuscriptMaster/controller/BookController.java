package com.MM.ManuscriptMaster.controller;

import com.MM.ManuscriptMaster.domain.model.Book;
import com.MM.ManuscriptMaster.service.BookService;
import org.springframework.web.bind.annotation.*;

import java.util.List;

@RestController
@RequestMapping("/api/books")
public class BookController {
    private  final BookService bookService;
    public BookController(BookService bookService) {
        this.bookService = bookService;
    }
    @GetMapping
    public List<Book> getAll(){
        return bookService.getAll();
    }

    @GetMapping("/{id}")
    public Book getById(@PathVariable Long id)
    {
        return  bookService.getOne(id);
    }

    @PostMapping
    public Book create(@RequestBody Book book)
    {
        book.setId(null);
        return bookService.create(book);
    }
    @PutMapping("/{id}")
    public Book update(@PathVariable Long id, @RequestBody Book book){
        return bookService.update(id, book);
    }
    @DeleteMapping("/{id}")
    public void delete(@PathVariable Long id){
        bookService.delete(id);
    }
}
