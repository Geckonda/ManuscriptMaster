package com.MM.ManuscriptMaster.service;

import com.MM.ManuscriptMaster.dto.request.BookCreateRequest;
import com.MM.ManuscriptMaster.dto.request.BookUpdateRequest;
import com.MM.ManuscriptMaster.dto.response.BookResponse;
import com.MM.ManuscriptMaster.dto.response.BookSimpleResponse;

import java.util.List;

public interface BookService {
    
    // Список в превью (краткий)
    List<BookSimpleResponse> getBooksPreview();
    
    // Список с полной информацией и эпизодами
    List<BookResponse> getBooksDetailed();
    
    // Одна книга в превью (краткая)
    BookSimpleResponse getBookPreview(Long id);
    
    // Одна книга с полной информацией и эпизодами
    BookResponse getBook(Long id);
    
    // CRUD операции
    BookResponse create(BookCreateRequest request);
    
    BookResponse update(Long id, BookUpdateRequest request);
    
    void delete(Long id);
}
