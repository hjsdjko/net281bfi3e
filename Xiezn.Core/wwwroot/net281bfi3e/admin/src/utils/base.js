const base = {
    get() {
        return {
            url : "http://localhost:8080/net281bfi3e/",
            name: "net281bfi3e",
            // 退出到首页链接
            indexUrl: 'http://localhost:8080/net281bfi3e/front/dist/index.html'
        };
    },
    getProjectName(){
        return {
            projectName: "基于ASP.NET的图书借阅系统的设计与实现"
        } 
    }
}
export default base
