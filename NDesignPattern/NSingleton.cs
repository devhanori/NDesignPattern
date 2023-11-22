/* 싱글톤 패턴 단점
 * 1. 클래스 간 의존성을 감춤
 * 2. 코드의 확장성에 영향을 줌
 *  -> 하나의 인스턴스를 가짐, 두 개의 인스턴스가 필요한 경우 불가능
 * 3. 코드의 테스트 용이성에 영향을 줌
 *  -> 전역 변수와 같은 효과가 나타남
 * 4. 매개변수가 있는 생성자를 지원하지 않음
 *  -> 해결방법
 *      1. init 함수를 통한 매개변수 전달
 *      2. get 속성에 매개변수 전달 -> 문제가 있음 사용 X
 *      3. 매개변수를 전역화
 */

namespace NDesignPattern
{
    // 기본 싱글톤
    public class NSingleton
    {
        public static readonly NSingleton instance = new NSingleton();
        private NSingleton() { }

    }

    // 지연 초기화
    public class Singleton<T> where T : class
    {
        private static readonly Lazy<T> _instance = new Lazy<T>(() => Activator.CreateInstance<T>(), true);

        public static T Instance
        {
            get
            {
                return _instance.Value;
            }
        }
    }

    // 대안 - 정적 매서드 활용
    public class NSingletonStatic
    {
        private static string id = "TESTTT";
        private NSingletonStatic() { }

        public static string getId()
        {
            return id;
        }

    }
}