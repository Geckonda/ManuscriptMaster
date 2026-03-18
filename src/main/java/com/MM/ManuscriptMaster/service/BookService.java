package com.MM.ManuscriptMaster.service;

import com.MM.ManuscriptMaster.domain.model.Book;
import com.MM.ManuscriptMaster.exception.NotFoundException;
import com.MM.ManuscriptMaster.repository.BookRepository;
import org.springframework.stereotype.Service;

import java.util.List;

@Service
public class BookService {
    private  final BookRepository bookRepository;
    public BookService(BookRepository bookRepository) {
        this.bookRepository = bookRepository;
    }

    public List<Book> getAll(){
        return bookRepository.findAll();
    }

    public Book getOne(Long id){
        return  bookRepository.findById(id)
                .orElseThrow(() -> new NotFoundException("Book not find with id " + id));
    }
    public Book create(Book book){
        return bookRepository.save(book);
    }
    public Book update(Long id, Book updatedBook){
        Book book = getOne(id);
        book.setTitle(updatedBook.getTitle());
        book.setAuthor(updatedBook.getAuthor());
        return bookRepository.save(book);
    }
    public void delete(Long id){
        bookRepository.deleteById(id);
    }
}
