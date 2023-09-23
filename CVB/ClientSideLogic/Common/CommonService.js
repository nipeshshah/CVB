//https://blog.logrocket.com/how-to-make-http-requests-like-a-pro-with-axios/
const serviceUrl = 'https://localhost:44304/'

// Function to make a GET request
function get(url, success) {
    try {
        axios.get(serviceUrl + url)
            .then(response => {
                console.log(response.data);
                success(response);
            });
    } catch (error) {
        console.error('GET request error:', error);
        throw error;
    }
}

function post(url, data, success) {
    axios.post(serviceUrl + url, data)
        .then((response) => {
            success(response);
        }, (error) => {
            console.log(error);
        });
}

function multipleget(urls) {
    //urls
    axios.all([
        axios.get('https://api.github.com/users/mapbox'),
        axios.get('https://api.github.com/users/phantomjs')
    ])
    .then(responseArr => {
        //this will be executed only when all requests are complete
        console.log('Date created: ', responseArr[0].data.created_at);
        console.log('Date created: ', responseArr[1].data.created_at);
    });
}