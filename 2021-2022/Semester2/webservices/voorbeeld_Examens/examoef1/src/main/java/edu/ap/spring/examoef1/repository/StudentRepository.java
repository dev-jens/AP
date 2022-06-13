package edu.ap.spring.examoef1.repository;

import org.springframework.stereotype.Repository;
import edu.ap.spring.examoef1.model.Student;
import org.springframework.data.repository.CrudRepository;


@Repository
public interface StudentRepository extends CrudRepository<Student, Long> {

    public boolean existsByFirstnameAndLastname(String firstname, String lastname);
    public Iterable<Student> findByOrderByLastnameAsc();
}


    

