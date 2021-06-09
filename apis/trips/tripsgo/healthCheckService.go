package tripsgo

import (
	"encoding/json"
	"fmt"
	"io/ioutil"
	"net/http"
)

func healthcheckGet(w http.ResponseWriter, r *http.Request) {

	data, err := ioutil.ReadFile("./tripsgo/settings.json")
	if err != nil {
		fmt.Print(err)
	}

	type Settings struct {
		Version string
	}

	var obj Settings

	// unmarshall it
	err = json.Unmarshal(data, &obj)
	if err != nil {
		fmt.Println("error:", err)
	}

	w.Header().Set("Content-Type", "application/json; charset=UTF-8")
	w.WriteHeader(http.StatusOK)

	hc := &Healthcheck{Message: "Trip Service Healthcheck V2", Status: "Healthy", Version: obj.Version}

	json.NewEncoder(w).Encode(hc)
}
