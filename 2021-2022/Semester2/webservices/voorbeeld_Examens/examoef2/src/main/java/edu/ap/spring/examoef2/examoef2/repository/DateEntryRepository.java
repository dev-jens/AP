package edu.ap.spring.examoef2.examoef2.repository;

import org.springframework.data.repository.CrudRepository;
import org.springframework.stereotype.Repository;

import edu.ap.spring.examoef2.examoef2.model.DateEntry;

@Repository
public interface DateEntryRepository extends CrudRepository<DateEntry, Long> {

}
    

