import org.junit.jupiter.api.Test;
import testing.calculator;

import static org.junit.jupiter.api.Assertions.*;

public class CalculatorTest {

    @Test
    void addOneAndIsThree(){
        calculator calc  = new calculator();
        int result = calc.add(1,2);
        assertEquals(3, result);
    }
    @Test
    void addOneAndThreeIsFour(){
        calculator calc  = new calculator();
        int result = calc.add(1,3);
        assertEquals(4, result);
    }
    @Test
    void addTwoAndThreeIsFive(){
        calculator calc  = new calculator();
        int result = calc.add(2,3);
        assertEquals(5, result);
    }
    @Test
    void resultFourAddOneIsFive(){
        calculator calc  = new calculator();
        int result = calc.addresult(1);
        assertEquals(5, result);
    }
    @Test
    void resultfourAddTwoIsSix(){
        calculator calc  = new calculator();
        calc.add(3,2)
;        int result = calc.addresult(1);
        assertEquals(5, result);
    }

    @Test
    void noResultAddOneIsOne(){
        calculator calc  = new calculator();
        calc.add(3,2);
        int result = calc.addresult(2);
        assertEquals(5, result);
    }

}
